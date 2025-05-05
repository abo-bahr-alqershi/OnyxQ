using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace ERP_Pro.Infrastructure.Identity.Services;

public class IdentityService : IIdentityService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<ApplicationRole> _roleManager;
    private readonly IConfiguration _configuration;

    public IdentityService(
        UserManager<ApplicationUser> userManager,
        RoleManager<ApplicationRole> roleManager,
        IConfiguration configuration)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _configuration = configuration;
    }

    public async Task<Result<string>> RegisterAsync(string userName, string email, string password, string firstName, string lastName)
    {
        var user = new ApplicationUser
        {
            UserName = userName,
            Email = email,
            FirstName = firstName,
            LastName = lastName,
            IsActive = true,
            CreatedOn = DateTime.UtcNow
        };

        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
        {
            var errors = result.Errors.ToDictionary(x => x.Code, x => new[] { x.Description });
            return Result<string>.Failure("Registration failed.", errors);
        }

        return Result<string>.Success(user.Id, "User registered successfully.");
    }

    public async Task<Result<(string Token, string RefreshToken)>> LoginAsync(string userName, string password)
    {
        var user = await _userManager.FindByNameAsync(userName);

        if (user == null || !await _userManager.CheckPasswordAsync(user, password))
        {
            return Result<(string, string)>.Failure("Invalid credentials.");
        }

        if (!user.IsActive)
        {
            return Result<(string, string)>.Failure("User is not active.");
        }

        var token = await GenerateJwtTokenAsync(user);
        var refreshToken = await GenerateRefreshTokenAsync(user);

        return Result<(string, string)>.Success((token, refreshToken), "Login successful.");
    }

    public async Task<Result> LogoutAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null)
        {
            return Result.Failure("User not found.");
        }

        user.RefreshToken = null;
        user.RefreshTokenExpiryTime = null;

        var result = await _userManager.UpdateAsync(user);

        return result.Succeeded
            ? Result.Success("Logout successful.")
            : Result.Failure("Logout failed.");
    }

    private async Task<string> GenerateJwtTokenAsync(ApplicationUser user)
    {
        var roles = await _userManager.GetRolesAsync(user);
        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id),
            new(ClaimTypes.Name, user.UserName!),
            new(ClaimTypes.Email, user.Email!),
            new("firstName", user.FirstName),
            new("lastName", user.LastName),
            new("fullName", user.FullName)
        };

        claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_configuration["Jwt:ExpiryInMinutes"]));

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: expires,
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private async Task<string> GenerateRefreshTokenAsync(ApplicationUser user)
    {
        var refreshToken = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        user.RefreshToken = refreshToken;
        user.RefreshTokenExpiryTime = DateTime.UtcNow.AddDays(7);
        
        await _userManager.UpdateAsync(user);
        
        return refreshToken;
    }
} 
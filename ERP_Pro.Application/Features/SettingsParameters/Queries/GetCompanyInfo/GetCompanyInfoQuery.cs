using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.Queries.GetCompanyInfo
{
    /// <summary>
    /// استعلام جلب معلومات الشركة
    /// </summary>
    public class GetCompanyInfoQuery : IRequest<CompanyInfoVm>
    {
        public Guid? Id { get; set; }
    }

    /// <summary>
    /// معالج استعلام جلب معلومات الشركة
    /// </summary>
    public class GetCompanyInfoQueryHandler : IRequestHandler<GetCompanyInfoQuery, CompanyInfoVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetCompanyInfoQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CompanyInfoVm> Handle(GetCompanyInfoQuery request, CancellationToken cancellationToken)
        {
            var entity = request.Id.HasValue
                ? await _context.CompanyInfo
                    .Include(c => c.Branches)
                    .FirstOrDefaultAsync(c => c.Id == request.Id.Value, cancellationToken)
                : await _context.CompanyInfo
                    .Include(c => c.Branches)
                    .FirstOrDefaultAsync(cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(CompanyInfo), request.Id ?? Guid.Empty);
            }

            return _mapper.Map<CompanyInfoVm>(entity);
        }
    }
} 
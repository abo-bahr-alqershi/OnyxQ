using ERP_Pro.Application.Abstractions.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Application.Behaviors;

public class TransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<TransactionBehavior<TRequest, TResponse>> _logger;

    public TransactionBehavior(IUnitOfWork unitOfWork, ILogger<TransactionBehavior<TRequest, TResponse>> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        try
        {
            await _unitOfWork.BeginTransactionAsync(cancellationToken);
            _logger.LogInformation("Begin transaction for {RequestName}", typeof(TRequest).Name);

            var response = await next();
            await _unitOfWork.CommitTransactionAsync(cancellationToken);
            
            _logger.LogInformation("Committed transaction for {RequestName}", typeof(TRequest).Name);
            return response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing transaction for {RequestName}", typeof(TRequest).Name);
            await _unitOfWork.RollbackTransactionAsync(cancellationToken);
            throw;
        }
    }
} 
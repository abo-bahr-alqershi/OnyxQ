using AutoMapper;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Common.Models;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetSequenceById
{
    /// <summary>
    /// استعلام الحصول على تسلسل بواسطة المعرف
    /// </summary>
    public class GetSequenceByIdQuery : IRequest<ResponseResult<SequenceDetailsDto>>
    {
        /// <summary>
        /// معرف التسلسل
        /// </summary>
        public Guid Id { get; set; }
    }
    
    /// <summary>
    /// معالج استعلام الحصول على تسلسل بواسطة المعرف
    /// </summary>
    public class GetSequenceByIdQueryHandler : IRequestHandler<GetSequenceByIdQuery, ResponseResult<SequenceDetailsDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        
        /// <summary>
        /// المنشئ
        /// </summary>
        public GetSequenceByIdQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        /// <summary>
        /// تنفيذ الاستعلام
        /// </summary>
        public async Task<ResponseResult<SequenceDetailsDto>> Handle(GetSequenceByIdQuery request, CancellationToken cancellationToken)
        {
            var sequence = await _context.SequenceDefinitions
                .Include(s => s.NumberAllocations)
                .Include(s => s.UsedNumbers)
                .Include(s => s.CanceledNumbers)
                .Include(s => s.NumberGaps)
                .FirstOrDefaultAsync(s => s.Id == request.Id, cancellationToken);
                
            if (sequence == null)
            {
                return ResponseResult<SequenceDetailsDto>.Failure(
                    "SequenceNotFound",
                    "التسلسل غير موجود"
                );
            }
            
            var result = _mapper.Map<SequenceDetailsDto>(sequence);
            return ResponseResult<SequenceDetailsDto>.Success(result);
        }
    }
} 
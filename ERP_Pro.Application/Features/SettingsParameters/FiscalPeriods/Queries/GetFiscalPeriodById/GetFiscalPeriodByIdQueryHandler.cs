using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Application.Common.Exceptions;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.GetFiscalPeriodById
{
    /// <summary>
    /// معالج استعلام جلب فترة محاسبية بالمعرف
    /// </summary>
    public class GetFiscalPeriodByIdQueryHandler : IRequestHandler<GetFiscalPeriodByIdQuery, FiscalPeriodDetailsDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;

        /// <summary>
        /// المنشئ
        /// </summary>
        public GetFiscalPeriodByIdQueryHandler(
            IApplicationDbContext context,
            IMapper mapper,
            IDateTime dateTime)
        {
            _context = context;
            _mapper = mapper;
            _dateTime = dateTime;
        }

        /// <summary>
        /// معالجة الاستعلام
        /// </summary>
        public async Task<FiscalPeriodDetailsDto> Handle(GetFiscalPeriodByIdQuery request, CancellationToken cancellationToken)
        {
            var fiscalPeriod = await _context.FiscalPeriods
                .Include(p => p.FiscalYear)
                .Include(p => p.PeriodLocks)
                .Include(p => p.PeriodAdjustments)
                .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);

            if (fiscalPeriod == null)
            {
                throw new NotFoundException(nameof(FiscalPeriod), request.Id);
            }

            var result = _mapper.Map<FiscalPeriodDetailsDto>(fiscalPeriod);
            
            // إضافة معلومات إضافية
            result.FiscalYearCode = fiscalPeriod.FiscalYear.Code;
            result.FiscalYearName = fiscalPeriod.FiscalYear.NameAr; // يمكن تعديله لاستخدام اللغة الحالية
            
            // تحديد ما إذا كانت هذه هي الفترة الحالية
            var currentDate = _dateTime.Now;
            result.IsCurrent = fiscalPeriod.StartDate <= currentDate && fiscalPeriod.EndDate >= currentDate;
            
            // جلب عدد القيود المحاسبية المرتبطة بالفترة (إذا كانت كيانات القيود موجودة في النظام)
            // TODO: تعديل هذا الجزء عند إنشاء كيانات القيود المحاسبية
            result.JournalEntriesCount = 0;
            
            // ترتيب عمليات التأمين والتسويات حسب التاريخ
            result.PeriodLocks = result.PeriodLocks
                .OrderByDescending(l => l.LockStartDate)
                .ToList();
            
            result.PeriodAdjustments = result.PeriodAdjustments
                .OrderByDescending(a => a.AdjustmentDate)
                .ToList();

            return result;
        }
    }
} 
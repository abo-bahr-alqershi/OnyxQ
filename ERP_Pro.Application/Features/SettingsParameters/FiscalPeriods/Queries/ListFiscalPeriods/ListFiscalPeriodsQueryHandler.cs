using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.SettingsParameters.Enums;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels;
using ERP_Pro.Application.Common.Interfaces;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.ListFiscalPeriods
{
    /// <summary>
    /// معالج استعلام جلب قائمة الفترات المحاسبية
    /// </summary>
    public class ListFiscalPeriodsQueryHandler : IRequestHandler<ListFiscalPeriodsQuery, List<FiscalPeriodListItemDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IDateTime _dateTime;

        /// <summary>
        /// المنشئ
        /// </summary>
        public ListFiscalPeriodsQueryHandler(
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
        public async Task<List<FiscalPeriodListItemDto>> Handle(ListFiscalPeriodsQuery request, CancellationToken cancellationToken)
        {
            var query = _context.FiscalPeriods
                .Include(p => p.PeriodLocks)
                .Include(p => p.PeriodAdjustments)
                .AsQueryable();

            // تطبيق فلاتر البحث
            if (request.FiscalYearId.HasValue)
            {
                query = query.Where(p => p.FiscalYearId == request.FiscalYearId.Value);
            }

            if (request.Status.HasValue)
            {
                var status = (FiscalPeriodStatusEnum)request.Status.Value;
                query = query.Where(p => p.Status == status);
            }

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
            {
                query = query.Where(p =>
                    p.Code.Contains(request.SearchTerm) ||
                    p.NameAr.Contains(request.SearchTerm) ||
                    p.NameEn.Contains(request.SearchTerm));
            }

            // تطبيق الترتيب
            query = ApplySorting(query, request.SortBy, request.SortDirection);

            // تطبيق التصفح
            var periods = await query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            // تحويل الكيانات إلى DTOs
            var result = _mapper.Map<List<FiscalPeriodListItemDto>>(periods);

            // إضافة معلومات إضافية
            var currentDate = _dateTime.Now;
            foreach (var periodDto in result)
            {
                // تحديد الفترة الحالية
                periodDto.IsCurrent = periodDto.StartDate <= currentDate && periodDto.EndDate >= currentDate;
                
                // حساب عدد عمليات التأمين والتسويات
                var period = periods.First(p => p.Id == periodDto.Id);
                periodDto.LocksCount = period.PeriodLocks.Count;
                periodDto.AdjustmentsCount = period.PeriodAdjustments.Count;
            }

            return result;
        }

        /// <summary>
        /// تطبيق الترتيب على الاستعلام
        /// </summary>
        private IQueryable<FiscalPeriod> ApplySorting(IQueryable<FiscalPeriod> query, string sortBy, string sortDirection)
        {
            bool isAscending = string.Equals(sortDirection, "asc", StringComparison.OrdinalIgnoreCase);

            return sortBy.ToLower() switch
            {
                "code" => isAscending 
                    ? query.OrderBy(p => p.Code) 
                    : query.OrderByDescending(p => p.Code),
                
                "namear" => isAscending 
                    ? query.OrderBy(p => p.NameAr) 
                    : query.OrderByDescending(p => p.NameAr),
                
                "nameen" => isAscending 
                    ? query.OrderBy(p => p.NameEn) 
                    : query.OrderByDescending(p => p.NameEn),
                
                "startdate" => isAscending 
                    ? query.OrderBy(p => p.StartDate) 
                    : query.OrderByDescending(p => p.StartDate),
                
                "enddate" => isAscending 
                    ? query.OrderBy(p => p.EndDate) 
                    : query.OrderByDescending(p => p.EndDate),
                
                "status" => isAscending 
                    ? query.OrderBy(p => p.Status) 
                    : query.OrderByDescending(p => p.Status),
                
                _ => isAscending 
                    ? query.OrderBy(p => p.PeriodNumber) 
                    : query.OrderByDescending(p => p.PeriodNumber)
            };
        }
    }
} 
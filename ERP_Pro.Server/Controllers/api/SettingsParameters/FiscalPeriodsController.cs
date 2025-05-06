using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.CreatePeriodManually;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.CreatePeriodsAutomatically;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.ChangePeriodStatus;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.LockPeriod;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.UnlockPeriod;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.CreatePeriodAdjustment;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.ListFiscalPeriods;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.GetFiscalPeriodById;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.GetCurrentFiscalPeriod;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.CheckPeriodStatusForDate;
using ERP_Pro.Server.Controllers;

namespace ERP_Pro.Server.Controllers.api.SettingsParameters
{
    /// <summary>
    /// وحدة تحكم الفترات المحاسبية
    /// </summary>
    [Route("api/settings/fiscal-periods")]
    public class FiscalPeriodsController : ApiControllerBase
    {
        /// <summary>
        /// الحصول على قائمة الفترات المحاسبية
        /// </summary>
        /// <param name="query">معاملات الاستعلام</param>
        /// <returns>قائمة الفترات المحاسبية</returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<FiscalPeriodListItemDto>>> GetFiscalPeriods([FromQuery] ListFiscalPeriodsQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// الحصول على تفاصيل فترة محاسبية محددة
        /// </summary>
        /// <param name="id">معرف الفترة المحاسبية</param>
        /// <returns>تفاصيل الفترة المحاسبية</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<FiscalPeriodDetailsDto>> GetFiscalPeriodById(Guid id)
        {
            return await Mediator.Send(new GetFiscalPeriodByIdQuery { Id = id });
        }

        /// <summary>
        /// الحصول على الفترة المحاسبية الحالية
        /// </summary>
        /// <param name="fiscalYearId">معرف السنة المالية (اختياري)</param>
        /// <returns>الفترة المحاسبية الحالية</returns>
        [HttpGet("current")]
        public async Task<ActionResult<FiscalPeriodDto>> GetCurrentFiscalPeriod([FromQuery] Guid? fiscalYearId)
        {
            return await Mediator.Send(new GetCurrentFiscalPeriodQuery { FiscalYearId = fiscalYearId });
        }

        /// <summary>
        /// التحقق من حالة الفترة لتاريخ محدد
        /// </summary>
        /// <param name="query">معاملات الاستعلام</param>
        /// <returns>حالة الفترة المحاسبية</returns>
        [HttpGet("check-status")]
        public async Task<ActionResult<PeriodStatusDto>> CheckPeriodStatusForDate([FromQuery] CheckPeriodStatusForDateQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// إنشاء فترات محاسبية تلقائياً
        /// </summary>
        /// <param name="fiscalYearId">معرف السنة المالية</param>
        /// <param name="command">بيانات إنشاء الفترات</param>
        /// <returns>النتيجة</returns>
        [HttpPost("/api/settings/fiscal-years/{fiscalYearId}/periods/auto-create")]
        [Authorize(Roles = "Admin,FinancialManager")]
        public async Task<ActionResult<bool>> CreatePeriodsAutomatically(Guid fiscalYearId, CreatePeriodsAutomaticallyCommand command)
        {
            if (fiscalYearId != command.FiscalYearId)
            {
                return BadRequest("معرف السنة المالية في العنوان لا يتطابق مع المعرف في البيانات المرسلة.");
            }

            return await Mediator.Send(command);
        }

        /// <summary>
        /// إنشاء فترة محاسبية يدوياً
        /// </summary>
        /// <param name="fiscalYearId">معرف السنة المالية</param>
        /// <param name="command">بيانات الفترة المحاسبية</param>
        /// <returns>معرف الفترة المحاسبية الجديدة</returns>
        [HttpPost("/api/settings/fiscal-years/{fiscalYearId}/periods")]
        [Authorize(Roles = "Admin,FinancialManager")]
        public async Task<ActionResult<Guid>> CreatePeriodManually(Guid fiscalYearId, CreatePeriodManuallyCommand command)
        {
            if (fiscalYearId != command.FiscalYearId)
            {
                return BadRequest("معرف السنة المالية في العنوان لا يتطابق مع المعرف في البيانات المرسلة.");
            }

            return await Mediator.Send(command);
        }

        /// <summary>
        /// تغيير حالة الفترة المحاسبية
        /// </summary>
        /// <param name="id">معرف الفترة المحاسبية</param>
        /// <param name="command">بيانات تغيير الحالة</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPatch("{id}/status")]
        [Authorize(Roles = "Admin,FinancialManager")]
        public async Task<ActionResult<bool>> ChangePeriodStatus(Guid id, ChangePeriodStatusCommand command)
        {
            if (id != command.FiscalPeriodId)
            {
                return BadRequest("معرف الفترة المحاسبية في العنوان لا يتطابق مع المعرف في البيانات المرسلة.");
            }

            return await Mediator.Send(command);
        }

        /// <summary>
        /// تأمين فترة محاسبية
        /// </summary>
        /// <param name="id">معرف الفترة المحاسبية</param>
        /// <param name="command">بيانات التأمين</param>
        /// <returns>معرف التأمين الجديد</returns>
        [HttpPost("{id}/lock")]
        [Authorize(Roles = "Admin,FinancialManager")]
        public async Task<ActionResult<Guid>> LockPeriod(Guid id, LockPeriodCommand command)
        {
            if (id != command.FiscalPeriodId)
            {
                return BadRequest("معرف الفترة المحاسبية في العنوان لا يتطابق مع المعرف في البيانات المرسلة.");
            }

            return await Mediator.Send(command);
        }

        /// <summary>
        /// إلغاء تأمين فترة محاسبية
        /// </summary>
        /// <param name="id">معرف الفترة المحاسبية</param>
        /// <param name="command">بيانات إلغاء التأمين</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPost("{id}/unlock")]
        [Authorize(Roles = "Admin,FinancialManager")]
        public async Task<ActionResult<bool>> UnlockPeriod(Guid id, UnlockPeriodCommand command)
        {
            if (id != command.FiscalPeriodId)
            {
                return BadRequest("معرف الفترة المحاسبية في العنوان لا يتطابق مع المعرف في البيانات المرسلة.");
            }

            return await Mediator.Send(command);
        }

        /// <summary>
        /// إنشاء تسوية للفترة المحاسبية
        /// </summary>
        /// <param name="id">معرف الفترة المحاسبية</param>
        /// <param name="command">بيانات التسوية</param>
        /// <returns>معرف التسوية الجديدة</returns>
        [HttpPost("{id}/adjustments")]
        [Authorize(Roles = "Admin,FinancialManager")]
        public async Task<ActionResult<Guid>> CreatePeriodAdjustment(Guid id, CreatePeriodAdjustmentCommand command)
        {
            if (id != command.FiscalPeriodId)
            {
                return BadRequest("معرف الفترة المحاسبية في العنوان لا يتطابق مع المعرف في البيانات المرسلة.");
            }

            return await Mediator.Send(command);
        }
    }
} 
using System;
using System.Threading.Tasks;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.ChangeCurrencyStatus;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateCurrency;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateCurrencyAccount;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateCurrencyRiskLimit;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.DeleteCurrency;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.SetBaseCurrency;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateCurrency;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateCurrencyAccount;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateCurrencyRiskLimit;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateCurrencyRounding;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.ConvertAmount;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetBaseCurrency;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencyAccounts;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencyByCode;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencyById;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencyRiskLimits;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencyRoundingRules;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.ListCurrencies;
using ERP_Pro.Server.Controllers.api;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Pro.Server.Controllers.api.v1.FinanceAccounting
{
    /// <summary>
    /// وحدة تحكم العملات
    /// </summary>
    [Authorize]
    [Route("api/finance-accounting/currencies")]
    public class CurrenciesController : ApiControllerBase
    {
        /// <summary>
        /// الحصول على قائمة العملات
        /// </summary>
        /// <param name="query">معاملات الاستعلام</param>
        /// <returns>قائمة العملات</returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<CurrencyListItemDto>>> GetCurrencies([FromQuery] ListCurrenciesQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// الحصول على تفاصيل عملة محددة بواسطة المعرف
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <returns>تفاصيل العملة</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CurrencyDetailsDto>> GetCurrencyById(Guid id)
        {
            return await Mediator.Send(new GetCurrencyByIdQuery { Id = id });
        }

        /// <summary>
        /// الحصول على عملة بواسطة الرمز
        /// </summary>
        /// <param name="code">رمز العملة</param>
        /// <returns>تفاصيل العملة</returns>
        [HttpGet("code/{code}")]
        public async Task<ActionResult<CurrencyDetailsDto>> GetCurrencyByCode(string code)
        {
            return await Mediator.Send(new GetCurrencyByCodeQuery { Code = code });
        }

        /// <summary>
        /// الحصول على العملة الأساسية
        /// </summary>
        /// <returns>العملة الأساسية</returns>
        [HttpGet("base")]
        public async Task<ActionResult<CurrencyDto>> GetBaseCurrency()
        {
            return await Mediator.Send(new GetBaseCurrencyQuery());
        }

        /// <summary>
        /// الحصول على الحسابات المرتبطة بالعملة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="accountType">نوع الحساب (اختياري)</param>
        /// <returns>قائمة الحسابات المرتبطة بالعملة</returns>
        [HttpGet("{id}/accounts")]
        public async Task<ActionResult<List<CurrencyAccountDto>>> GetCurrencyAccounts(Guid id, [FromQuery] string accountType = null)
        {
            return await Mediator.Send(new GetCurrencyAccountsQuery { CurrencyId = id, AccountType = accountType });
        }

        /// <summary>
        /// الحصول على قواعد تقريب العملة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="transactionType">نوع المعاملة (اختياري)</param>
        /// <param name="isActive">فعال فقط (اختياري)</param>
        /// <returns>قائمة قواعد تقريب العملة</returns>
        [HttpGet("{id}/rounding-rules")]
        public async Task<ActionResult<List<CurrencyRoundingRuleDto>>> GetCurrencyRoundingRules(Guid id, [FromQuery] string transactionType = null, [FromQuery] bool? isActive = null)
        {
            return await Mediator.Send(new GetCurrencyRoundingRulesQuery { CurrencyId = id, TransactionType = transactionType, IsActive = isActive });
        }

        /// <summary>
        /// الحصول على حدود مخاطر العملة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="limitType">نوع الحد (اختياري)</param>
        /// <param name="isActive">فعال فقط (اختياري)</param>
        /// <returns>قائمة حدود مخاطر العملة</returns>
        [HttpGet("{id}/risk-limits")]
        public async Task<ActionResult<List<CurrencyRiskLimitDto>>> GetCurrencyRiskLimits(Guid id, [FromQuery] string limitType = null, [FromQuery] bool? isActive = null)
        {
            return await Mediator.Send(new GetCurrencyRiskLimitsQuery { CurrencyId = id, LimitType = limitType, IsActive = isActive });
        }

        /// <summary>
        /// إنشاء عملة جديدة
        /// </summary>
        /// <param name="command">بيانات العملة الجديدة</param>
        /// <returns>معرف العملة المنشأة</returns>
        [HttpPost]
        public async Task<ActionResult<Guid>> CreateCurrency(CreateCurrencyCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// تحديث بيانات عملة موجودة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="command">بيانات العملة المحدثة</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> UpdateCurrency(Guid id, UpdateCurrencyCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// حذف عملة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <returns>نتيجة العملية</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteCurrency(Guid id)
        {
            return await Mediator.Send(new DeleteCurrencyCommand { Id = id });
        }

        /// <summary>
        /// تغيير حالة العملة (نشطة/معطلة)
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="command">بيانات تغيير الحالة</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPatch("{id}/status")]
        public async Task<ActionResult<bool>> ChangeCurrencyStatus(Guid id, ChangeCurrencyStatusCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// تعيين العملة كعملة أساسية
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPost("{id}/set-base")]
        public async Task<ActionResult<bool>> SetBaseCurrency(Guid id)
        {
            return await Mediator.Send(new SetBaseCurrencyCommand { Id = id });
        }

        /// <summary>
        /// تحديث قواعد تقريب العملة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="command">بيانات التقريب</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPost("{id}/update-rounding")]
        public async Task<ActionResult<bool>> UpdateCurrencyRounding(Guid id, UpdateCurrencyRoundingCommand command)
        {
            if (id != command.CurrencyId)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// إضافة حساب للعملة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="command">بيانات الحساب</param>
        /// <returns>معرف الحساب المضاف</returns>
        [HttpPost("{id}/accounts")]
        public async Task<ActionResult<Guid>> CreateCurrencyAccount(Guid id, CreateCurrencyAccountCommand command)
        {
            if (id != command.CurrencyId)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// تحديث حساب مرتبط بالعملة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="accountId">معرف الحساب</param>
        /// <param name="command">بيانات الحساب المحدثة</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPut("{id}/accounts/{accountId}")]
        public async Task<ActionResult<bool>> UpdateCurrencyAccount(Guid id, Guid accountId, UpdateCurrencyAccountCommand command)
        {
            if (id != command.CurrencyId || accountId != command.AccountId)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// إضافة حد مخاطر للعملة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="command">بيانات حد المخاطر</param>
        /// <returns>معرف حد المخاطر المضاف</returns>
        [HttpPost("{id}/risk-limits")]
        public async Task<ActionResult<Guid>> CreateCurrencyRiskLimit(Guid id, CreateCurrencyRiskLimitCommand command)
        {
            if (id != command.CurrencyId)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// تحديث حد مخاطر للعملة
        /// </summary>
        /// <param name="id">معرف العملة</param>
        /// <param name="limitId">معرف الحد</param>
        /// <param name="command">بيانات حد المخاطر المحدثة</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPut("{id}/risk-limits/{limitId}")]
        public async Task<ActionResult<bool>> UpdateCurrencyRiskLimit(Guid id, Guid limitId, UpdateCurrencyRiskLimitCommand command)
        {
            if (id != command.CurrencyId || limitId != command.RiskLimitId)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// تحويل مبلغ من عملة إلى أخرى
        /// </summary>
        /// <param name="query">معاملات التحويل</param>
        /// <returns>المبلغ المحول</returns>
        [HttpPost("convert")]
        public async Task<ActionResult<CurrencyConversionDto>> ConvertAmount(ConvertAmountQuery query)
        {
            return await Mediator.Send(query);
        }
    }
} 
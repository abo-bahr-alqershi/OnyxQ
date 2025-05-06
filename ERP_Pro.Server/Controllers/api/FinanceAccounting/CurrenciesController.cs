using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.AddExchangeRate;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.ChangeCurrencyStatus;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateCurrency;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateExchangeRate;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateRiskLimit;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateRoundingRule;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.DeleteExchangeRate;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.DeleteRiskLimit;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.DeleteRoundingRule;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateCurrency;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateExchangeRate;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateRiskLimit;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateRoundingRule;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencies;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencyById;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetExchangeRateHistory;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetRiskLimits;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetRoundingRules;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Pro.Server.Controllers.api.FinanceAccounting
{
    [Route("api/finance/currencies")]
    [ApiController]
    [Authorize]
    public class CurrenciesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CurrenciesController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        #region Currency Operations

        /// <summary>
        /// الحصول على قائمة العملات
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<List<CurrencyDto>>> GetAll([FromQuery] bool? activeOnly = null, [FromQuery] string searchTerm = null)
        {
            var query = new GetCurrenciesQuery
            {
                ActiveOnly = activeOnly,
                SearchTerm = searchTerm
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }

        /// <summary>
        /// الحصول على تفاصيل عملة محددة
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<CurrencyDetailsDto>> GetById(Guid id)
        {
            var query = new GetCurrencyByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        /// <summary>
        /// إنشاء عملة جديدة
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateCurrencyCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result }, result);
        }

        /// <summary>
        /// تحديث بيانات عملة
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Update(Guid id, UpdateCurrencyCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("معرف العملة في المسار لا يطابق المعرف في البيانات المرسلة");
            }

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// تغيير حالة عملة (تفعيل/تعطيل)
        /// </summary>
        [HttpPatch("{id}/status")]
        public async Task<ActionResult<bool>> ChangeStatus(Guid id, [FromBody] bool activate)
        {
            var command = new ChangeCurrencyStatusCommand(id, activate);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        #endregion

        #region Exchange Rates Operations

        /// <summary>
        /// إضافة سعر صرف جديد للعملة المحددة
        /// </summary>
        [HttpPost("{id}/exchange-rates")]
        public async Task<ActionResult<Guid>> AddExchangeRate(Guid id, AddExchangeRateCommand command)
        {
            if (id != command.CurrencyId)
            {
                return BadRequest("معرف العملة في المسار لا يطابق المعرف في البيانات المرسلة");
            }

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// الحصول على تاريخ أسعار صرف عملة معينة
        /// </summary>
        [HttpGet("exchange-rates/history/{currencyId}")]
        public async Task<ActionResult<List<ExchangeRateHistoryDto>>> GetExchangeRateHistory(
            Guid currencyId,
            [FromQuery] DateTime? startDate = null,
            [FromQuery] DateTime? endDate = null,
            [FromQuery] string rateType = null,
            [FromQuery] int? pageNumber = null,
            [FromQuery] int? pageSize = null)
        {
            var query = new GetExchangeRateHistoryQuery
            {
                CurrencyId = currencyId,
                StartDate = startDate,
                EndDate = endDate,
                RateType = rateType,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            var result = await _mediator.Send(query);
            return Ok(result);
        }

        /// <summary>
        /// إضافة سعر صرف جديد
        /// </summary>
        [HttpPost("exchange-rates")]
        public async Task<ActionResult<Guid>> CreateExchangeRate([FromBody] CreateExchangeRateCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// تحديث سعر صرف
        /// </summary>
        [HttpPut("exchange-rates/{id}")]
        public async Task<ActionResult> UpdateExchangeRate(Guid id, [FromBody] UpdateExchangeRateCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("معرف سعر الصرف في المسار لا يطابق المعرف في البيانات المرسلة");
            }

            await _mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// حذف سعر صرف
        /// </summary>
        [HttpDelete("exchange-rates/{id}")]
        public async Task<ActionResult> DeleteExchangeRate(Guid id)
        {
            await _mediator.Send(new DeleteExchangeRateCommand { Id = id });
            return NoContent();
        }

        #endregion

        #region Rounding Rules Operations

        /// <summary>
        /// الحصول على قواعد تقريب العملة
        /// </summary>
        [HttpGet("rounding-rules/currency/{currencyId}")]
        public async Task<ActionResult<List<CurrencyRoundingRuleDto>>> GetRoundingRules(Guid currencyId)
        {
            var result = await _mediator.Send(new GetRoundingRulesQuery { CurrencyId = currencyId });
            return Ok(result);
        }

        /// <summary>
        /// إنشاء قاعدة تقريب جديدة
        /// </summary>
        [HttpPost("rounding-rules")]
        public async Task<ActionResult<Guid>> CreateRoundingRule([FromBody] CreateRoundingRuleCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// تحديث قاعدة تقريب
        /// </summary>
        [HttpPut("rounding-rules/{id}")]
        public async Task<ActionResult> UpdateRoundingRule(Guid id, [FromBody] UpdateRoundingRuleCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("معرف قاعدة التقريب في المسار لا يطابق المعرف في البيانات المرسلة");
            }

            await _mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// حذف قاعدة تقريب
        /// </summary>
        [HttpDelete("rounding-rules/{id}")]
        public async Task<ActionResult> DeleteRoundingRule(Guid id)
        {
            await _mediator.Send(new DeleteRoundingRuleCommand { Id = id });
            return NoContent();
        }

        #endregion

        #region Risk Limits Operations

        /// <summary>
        /// الحصول على حدود مخاطر العملة
        /// </summary>
        [HttpGet("risk-limits/currency/{currencyId}")]
        public async Task<ActionResult<List<CurrencyRiskLimitDto>>> GetRiskLimits(Guid currencyId)
        {
            var result = await _mediator.Send(new GetRiskLimitsQuery { CurrencyId = currencyId });
            return Ok(result);
        }

        /// <summary>
        /// إنشاء حد مخاطر جديد
        /// </summary>
        [HttpPost("risk-limits")]
        public async Task<ActionResult<Guid>> CreateRiskLimit([FromBody] CreateRiskLimitCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// تحديث حد مخاطر
        /// </summary>
        [HttpPut("risk-limits/{id}")]
        public async Task<ActionResult> UpdateRiskLimit(Guid id, [FromBody] UpdateRiskLimitCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("معرف حد المخاطر في المسار لا يطابق المعرف في البيانات المرسلة");
            }

            await _mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// حذف حد مخاطر
        /// </summary>
        [HttpDelete("risk-limits/{id}")]
        public async Task<ActionResult> DeleteRiskLimit(Guid id)
        {
            await _mediator.Send(new DeleteRiskLimitCommand { Id = id });
            return NoContent();
        }

        #endregion
    }
} 
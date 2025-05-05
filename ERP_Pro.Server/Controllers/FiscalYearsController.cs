using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ERP_Pro.Application.Features.FiscalYears.Commands;
using ERP_Pro.Application.Features.FiscalYears.Dtos;
using ERP_Pro.Application.Features.FiscalYears.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Pro.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class FiscalYearsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FiscalYearsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<FiscalYearDto>>> Get([FromQuery] ListFiscalYearsQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FiscalYearDto>> GetById(Guid id, [FromQuery] bool includePeriods = false)
        {
            var query = new GetFiscalYearByIdQuery { Id = id, IncludePeriods = includePeriods };
            var fiscalYear = await _mediator.Send(query);

            if (fiscalYear == null)
                return NotFound();

            return fiscalYear;
        }

        [HttpGet("code/{code}")]
        public async Task<ActionResult<FiscalYearDto>> GetByCode(string code, [FromQuery] bool includePeriods = false)
        {
            var query = new GetFiscalYearByCodeQuery { Code = code, IncludePeriods = includePeriods };
            var fiscalYear = await _mediator.Send(query);

            if (fiscalYear == null)
                return NotFound();

            return fiscalYear;
        }

        [HttpGet("default")]
        public async Task<ActionResult<FiscalYearDto>> GetDefault([FromQuery] bool includePeriods = false)
        {
            var query = new GetDefaultFiscalYearQuery { IncludePeriods = includePeriods };
            var fiscalYear = await _mediator.Send(query);

            if (fiscalYear == null)
                return NotFound();

            return fiscalYear;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateFiscalYearCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Update(Guid id, UpdateFiscalYearCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            var result = await _mediator.Send(command);
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            var command = new DeleteFiscalYearCommand { Id = id };
            var result = await _mediator.Send(command);
            return result;
        }

        [HttpPut("{id}/status")]
        public async Task<ActionResult<bool>> ChangeStatus(Guid id, ChangeFiscalYearStatusCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            var result = await _mediator.Send(command);
            return result;
        }

        [HttpPut("{id}/default")]
        public async Task<ActionResult<bool>> SetDefault(Guid id)
        {
            var command = new SetDefaultFiscalYearCommand { Id = id };
            var result = await _mediator.Send(command);
            return result;
        }

        [HttpGet("{fiscalYearId}/periods")]
        public async Task<ActionResult<List<FiscalPeriodDto>>> GetPeriods(Guid fiscalYearId, [FromQuery] ListFiscalPeriodsQuery query)
        {
            if (fiscalYearId != query.FiscalYearId)
                return BadRequest();

            return await _mediator.Send(query);
        }

        [HttpGet("periods/{id}")]
        public async Task<ActionResult<FiscalPeriodDto>> GetPeriodById(Guid id)
        {
            var query = new GetFiscalPeriodByIdQuery { Id = id };
            var period = await _mediator.Send(query);

            if (period == null)
                return NotFound();

            return period;
        }

        [HttpGet("periods/current")]
        public async Task<ActionResult<FiscalPeriodDto>> GetCurrentPeriod([FromQuery] Guid? fiscalYearId = null)
        {
            var query = new GetCurrentFiscalPeriodQuery { FiscalYearId = fiscalYearId };
            var period = await _mediator.Send(query);

            if (period == null)
                return NotFound();

            return period;
        }

        [HttpGet("periods/bydate")]
        public async Task<ActionResult<FiscalPeriodDto>> GetPeriodByDate([FromQuery] DateTime date, [FromQuery] Guid? fiscalYearId = null)
        {
            var query = new GetPeriodByDateQuery { Date = date, FiscalYearId = fiscalYearId };
            var period = await _mediator.Send(query);

            if (period == null)
                return NotFound();

            return period;
        }

        [HttpPost("periods")]
        public async Task<ActionResult<Guid>> CreatePeriod(CreateFiscalPeriodCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetPeriodById), new { id }, id);
        }

        [HttpPost("{fiscalYearId}/periods/automatic")]
        public async Task<ActionResult<bool>> CreatePeriodsAutomatically(Guid fiscalYearId, CreatePeriodsAutomaticallyCommand command)
        {
            if (fiscalYearId != command.FiscalYearId)
                return BadRequest();

            var result = await _mediator.Send(command);
            return result;
        }
    }
} 
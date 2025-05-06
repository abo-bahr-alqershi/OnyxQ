using System;
using System.Threading.Tasks;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.CreateSequence;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.UpdateSequence;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.DeleteSequence;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.ChangeSequenceStatus;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.ResetSequenceCounter;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.ReserveNumberRange;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.ReleaseReservedNumber;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Commands.CancelNumber;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetSequenceById;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetSequenceByCode;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.ListSequences;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetNextNumber;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.ValidateNumber;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetSequenceNumbersHistory;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetSequenceAuditLog;
using ERP_Pro.Application.Features.SettingsParameters.Sequences.Queries.GetNumberGaps;
using ERP_Pro.Server.Controllers.api;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ERP_Pro.Server.Controllers.api.v1.SettingsParameters
{
    /// <summary>
    /// وحدة تحكم إدارة التسلسلات الرقمية
    /// </summary>
    [Authorize]
    [Route("api/settings/sequences")]
    public class SequencesController : ApiControllerBase
    {
        /// <summary>
        /// الحصول على قائمة التسلسلات
        /// </summary>
        /// <param name="query">معاملات الاستعلام</param>
        /// <returns>قائمة التسلسلات</returns>
        [HttpGet]
        public async Task<ActionResult<PaginatedList<SequenceListItemDto>>> GetSequences([FromQuery] ListSequencesQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// الحصول على تفاصيل تسلسل محدد بواسطة المعرف
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <returns>تفاصيل التسلسل</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<SequenceDetailsDto>> GetSequenceById(Guid id)
        {
            return await Mediator.Send(new GetSequenceByIdQuery { Id = id });
        }

        /// <summary>
        /// الحصول على تسلسل بواسطة الرمز
        /// </summary>
        /// <param name="code">رمز التسلسل</param>
        /// <returns>تفاصيل التسلسل</returns>
        [HttpGet("code/{code}")]
        public async Task<ActionResult<SequenceDetailsDto>> GetSequenceByCode(string code)
        {
            return await Mediator.Send(new GetSequenceByCodeQuery { Code = code });
        }

        /// <summary>
        /// إنشاء تسلسل جديد
        /// </summary>
        /// <param name="command">بيانات التسلسل الجديد</param>
        /// <returns>معرف التسلسل المنشأ</returns>
        [HttpPost]
        public async Task<ActionResult<Guid>> CreateSequence(CreateSequenceCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// تحديث بيانات تسلسل موجود
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <param name="command">بيانات التسلسل المحدثة</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> UpdateSequence(Guid id, UpdateSequenceCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// حذف تسلسل
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <returns>نتيجة العملية</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteSequence(Guid id)
        {
            return await Mediator.Send(new DeleteSequenceCommand { Id = id });
        }

        /// <summary>
        /// تغيير حالة التسلسل (نشط/معطل)
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <param name="command">بيانات تغيير الحالة</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPatch("{id}/status")]
        public async Task<ActionResult<bool>> ChangeSequenceStatus(Guid id, ChangeSequenceStatusCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// إعادة تعيين عداد التسلسل
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <param name="command">بيانات إعادة التعيين</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPost("{id}/reset-counter")]
        public async Task<ActionResult<bool>> ResetSequenceCounter(Guid id, ResetSequenceCounterCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// الحصول على الرقم التالي في التسلسل
        /// </summary>
        /// <param name="query">معاملات الاستعلام</param>
        /// <returns>الرقم التالي</returns>
        [HttpGet("next-number")]
        public async Task<ActionResult<NextNumberDto>> GetNextNumber([FromQuery] GetNextNumberQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// حجز نطاق من الأرقام
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <param name="command">بيانات حجز النطاق</param>
        /// <returns>معرف الحجز</returns>
        [HttpPost("{id}/reserve-range")]
        public async Task<ActionResult<Guid>> ReserveNumberRange(Guid id, ReserveNumberRangeCommand command)
        {
            if (id != command.SequenceId)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// إلغاء حجز رقم محجوز
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <param name="command">بيانات إلغاء الحجز</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPost("{id}/release-number")]
        public async Task<ActionResult<bool>> ReleaseReservedNumber(Guid id, ReleaseReservedNumberCommand command)
        {
            if (id != command.SequenceId)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// إلغاء رقم مستخدم
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <param name="command">بيانات إلغاء الرقم</param>
        /// <returns>نتيجة العملية</returns>
        [HttpPost("{id}/cancel-number")]
        public async Task<ActionResult<bool>> CancelNumber(Guid id, CancelNumberCommand command)
        {
            if (id != command.SequenceId)
                return BadRequest();

            return await Mediator.Send(command);
        }

        /// <summary>
        /// التحقق من صحة رقم تسلسلي
        /// </summary>
        /// <param name="query">معاملات التحقق</param>
        /// <returns>نتيجة التحقق</returns>
        [HttpPost("validate-number")]
        public async Task<ActionResult<NumberValidationResultDto>> ValidateNumber(ValidateNumberQuery query)
        {
            return await Mediator.Send(query);
        }

        /// <summary>
        /// الحصول على سجل الأرقام المستخدمة للتسلسل
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <param name="query">معاملات الاستعلام</param>
        /// <returns>سجل الأرقام</returns>
        [HttpGet("{id}/numbers-history")]
        public async Task<ActionResult<PaginatedList<SequenceNumberHistoryDto>>> GetSequenceNumbersHistory(Guid id, [FromQuery] GetSequenceNumbersHistoryQuery query)
        {
            if (id != query.SequenceId)
                return BadRequest();

            return await Mediator.Send(query);
        }

        /// <summary>
        /// الحصول على سجل تدقيق التسلسل
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <param name="query">معاملات الاستعلام</param>
        /// <returns>سجل التدقيق</returns>
        [HttpGet("{id}/audit-log")]
        public async Task<ActionResult<PaginatedList<SequenceAuditLogDto>>> GetSequenceAuditLog(Guid id, [FromQuery] GetSequenceAuditLogQuery query)
        {
            if (id != query.SequenceId)
                return BadRequest();

            return await Mediator.Send(query);
        }

        /// <summary>
        /// الحصول على فجوات الأرقام في التسلسل
        /// </summary>
        /// <param name="id">معرف التسلسل</param>
        /// <param name="query">معاملات الاستعلام</param>
        /// <returns>قائمة الفجوات</returns>
        [HttpGet("{id}/gaps")]
        public async Task<ActionResult<PaginatedList<NumberGapDto>>> GetNumberGaps(Guid id, [FromQuery] GetNumberGapsQuery query)
        {
            if (id != query.SequenceId)
                return BadRequest();

            return await Mediator.Send(query);
        }
    }
} 
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ERP_Pro.Application.Features.SettingsParameters.Commands.CreateCompanyInfo;
using ERP_Pro.Application.Features.SettingsParameters.Commands.UpdateCompanyInfo;
using ERP_Pro.Application.Features.SettingsParameters.Queries.GetCompanyInfo;

namespace ERP_Pro.Server.Controllers.api.SettingsParameters
{
    /// <summary>
    /// وحدة تحكم معلومات الشركة
    /// </summary>
    [Route("api/settings/company")]
    public class CompanyInfoController : ApiControllerBase
    {
        /// <summary>
        /// الحصول على معلومات الشركة
        /// </summary>
        /// <returns>بيانات الشركة</returns>
        [HttpGet]
        public async Task<ActionResult<CompanyInfoVm>> Get()
        {
            return await Mediator.Send(new GetCompanyInfoQuery());
        }

        /// <summary>
        /// الحصول على معلومات شركة محددة
        /// </summary>
        /// <param name="id">معرف الشركة</param>
        /// <returns>بيانات الشركة</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyInfoVm>> Get(Guid id)
        {
            return await Mediator.Send(new GetCompanyInfoQuery { Id = id });
        }

        /// <summary>
        /// إنشاء معلومات شركة جديدة
        /// </summary>
        /// <param name="command">أمر إنشاء الشركة</param>
        /// <returns>معرف الشركة الجديدة</returns>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Guid>> Create(CreateCompanyInfoCommand command)
        {
            return await Mediator.Send(command);
        }

        /// <summary>
        /// تحديث معلومات الشركة
        /// </summary>
        /// <param name="id">معرف الشركة</param>
        /// <param name="command">أمر تحديث الشركة</param>
        /// <returns>رمز الاستجابة</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Update(Guid id, UpdateCompanyInfoCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);

            return NoContent();
        }
    }
} 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.CreateBranch;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.UpdateBranch;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.ChangeBranchStatus;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Commands.DeleteBranch;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Queries.GetBranchById;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Queries.ListBranches;
using ERP_Pro.Application.Features.SettingsParameters.Branches.Queries.GetBranchHierarchy;
using ERP_Pro.Application.Features.SettingsParameters.Branches.ViewModels;
using ERP_Pro.Application.Common.Models;

namespace ERP_Pro.Server.Controllers.api.SettingsParameters
{
    /// <summary>
    /// وحدة تحكم إدارة الفروع
    /// </summary>
    [Route("api/settings/branches")]
    public class BranchesController : ApiControllerBase
    {
        /// <summary>
        /// الحصول على قائمة الفروع
        /// </summary>
        /// <param name="companyId">معرف الشركة (اختياري)</param>
        /// <param name="activeOnly">الفروع النشطة فقط (اختياري)</param>
        /// <returns>قائمة الفروع</returns>
        [HttpGet]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<PaginatedList<BranchListItemDto>>> GetBranches([FromQuery] ListBranchesQuery query)
        {
            return await Mediator.Send(query);
        }
        
        /// <summary>
        /// الحصول على الهيكل الهرمي للفروع
        /// </summary>
        [HttpGet("hierarchy")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<List<BranchHierarchyItemDto>>> GetBranchHierarchy([FromQuery] GetBranchHierarchyQuery query)
        {
            return await Mediator.Send(query);
        }
        
        /// <summary>
        /// الحصول على تفاصيل فرع محدد
        /// </summary>
        /// <param name="id">معرف الفرع</param>
        /// <returns>تفاصيل الفرع</returns>
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<BranchDetailsDto>> GetBranch(Guid id, [FromQuery] bool includeWarehouses = true, [FromQuery] bool includeDocuments = true, [FromQuery] bool includeChildBranches = true)
        {
            var query = new GetBranchByIdQuery
            {
                Id = id,
                IncludeWarehouses = includeWarehouses,
                IncludeDocuments = includeDocuments,
                IncludeChildBranches = includeChildBranches
            };
            
            return await Mediator.Send(query);
        }
        
        /// <summary>
        /// إنشاء فرع جديد
        /// </summary>
        /// <param name="command">أمر إنشاء الفرع</param>
        /// <returns>معرف الفرع الجديد</returns>
        [HttpPost]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult<Guid>> CreateBranch(CreateBranchCommand command)
        {
            var branchId = await Mediator.Send(command);
            
            return CreatedAtAction(nameof(GetBranch), new { id = branchId }, branchId);
        }
        
        /// <summary>
        /// تحديث بيانات فرع
        /// </summary>
        /// <param name="id">معرف الفرع</param>
        /// <param name="command">أمر تحديث الفرع</param>
        /// <returns>رمز الاستجابة</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> UpdateBranch(Guid id, UpdateBranchCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("معرف الفرع في العنوان وفي النموذج غير متطابقين");
            }
            
            await Mediator.Send(command);
            
            return NoContent();
        }
        
        /// <summary>
        /// تغيير حالة فرع
        /// </summary>
        [HttpPatch("{id}/status")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> ChangeBranchStatus(Guid id, [FromBody] string status)
        {
            var command = new ChangeBranchStatusCommand
            {
                Id = id,
                Status = status
            };
            
            await Mediator.Send(command);
            
            return NoContent();
        }
        
        /// <summary>
        /// حذف فرع
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<ActionResult> DeleteBranch(Guid id, [FromQuery] bool deleteDependents = false)
        {
            var command = new DeleteBranchCommand
            {
                Id = id,
                DeleteDependents = deleteDependents
            };
            
            await Mediator.Send(command);
            
            return NoContent();
        }
    }
} 
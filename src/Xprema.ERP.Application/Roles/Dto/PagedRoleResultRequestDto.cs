using Abp.Application.Services.Dto;

namespace Xprema.ERP.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


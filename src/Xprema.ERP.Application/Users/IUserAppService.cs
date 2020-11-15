using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Xprema.ERP.Roles.Dto;
using Xprema.ERP.Users.Dto;

namespace Xprema.ERP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}

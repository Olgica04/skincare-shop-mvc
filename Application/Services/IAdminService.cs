using Application.Dto.Admin;
using Application.Dto.Auth;

namespace Application.Services
{
    public interface IAdminService
    {
        AdminDto GetAdmin(int id);
        AdminDto Login(LoginDto loginDto);
    }
}
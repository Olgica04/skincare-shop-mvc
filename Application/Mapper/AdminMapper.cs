using Application.Dto.Admin;
using Domain.Entities;

namespace Application.Mapper
{
    public static class AdminMapper
    {
        public static AdminDto ToAdminDto(this Admin admin)
        {
            return new()
            {
                Id = admin.Id,
                Username = admin.Username,
                Password = admin.Password,
            };
        }
    }
}
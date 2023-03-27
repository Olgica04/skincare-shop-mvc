using Application.Dto.Admin;
using Application.Dto.Auth;
using Application.Mapper;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Repository;

namespace Application.Services.Implementation
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<Admin> _repository;
        public AdminService(IRepository<Admin> repository)
        {
            _repository = repository;
        }
        public AdminDto GetAdmin(int id)
        {
            var admin = _repository.GetById(id) ?? throw new Exception("Not found");

            return admin.ToAdminDto();
        }
        public AdminDto Login(LoginDto loginDto)
        {
            var admin = _repository.Query().FirstOrDefault(x => x.Username == loginDto.Userame)
                ?? throw new Exception("Unauthorized");

            if (admin.Password != PasswordHasher.HashPassword(loginDto.Password))
            {
                throw new Exception("Unauthorized");
            }

            return admin.ToAdminDto();
        }
    }
}
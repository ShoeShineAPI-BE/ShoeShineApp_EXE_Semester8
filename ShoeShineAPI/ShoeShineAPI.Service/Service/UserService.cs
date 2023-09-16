﻿using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using ShoeShineAPI.Core.DTOs;
using ShoeShineAPI.Core.IRepositories;
using ShoeShineAPI.Core.Model;
using ShoeShineAPI.Service.Inheritance_Class;
using ShoeShineAPI.Service.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShineAPI.Service.Service
{
	public class UserService : CommonAbstract<User>, IUserService
	{
		IUnitRepository _unit;
		private readonly IConfiguration _configuration ;
		private readonly IMemoryCache _memoryCache;
		public UserService(IUnitRepository unit, IConfiguration configuration, IMemoryCache memoryCache)
		{
			_unit = unit;
			_configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
			_memoryCache = memoryCache ?? throw new ArgumentNullException(nameof(memoryCache));
			ProvideToken.Initialize(_configuration, _memoryCache);
		}

		public string CreateToken(Guid userId)
		{
			return ProvideToken.Instance.GenerateToken(userId);
		}
		public async Task<User?> CheckLogin(string account, string password)
		{
			IEnumerable<User> users =await GetAllDataAsync();
			var checkLogin= (from u in users where u.UserAccount== account && u.UserPassword==password select u)
							.FirstOrDefault();
			if(checkLogin != null) return checkLogin;
			return null;
		}
        public async Task<bool> RegisterUser(RegistrationDTO registrationDTO)
        {
            if (await EmailExists(registrationDTO.UserEmail))
            {
                return false;
            }

            if (registrationDTO.UserPassword != registrationDTO.ConfirmPassword)
            {
                return false;
            }

            var newUser = new User
            {
                UserId = Guid.NewGuid(),
                UserName = registrationDTO.UserName,
                UserEmail = registrationDTO.UserEmail,
                UserPassword = registrationDTO.UserPassword,
            };

            await _unit.UserRepository.Add(newUser);

            return true;
        }

        protected override async Task<IEnumerable<User>> GetAllDataAsync()
		{
			return await _unit.UserRepository.GetAll();
		}

		public async Task<IEnumerable<User>> GetUserAsnyc()
		{
			var users= await GetAllDataAsync();
			return users;
		}
        private async Task<bool> EmailExists(string email)
        {
            IEnumerable<User> users = await GetAllDataAsync();
            return users.Any(u => u.UserEmail == email);
        }
    }
}

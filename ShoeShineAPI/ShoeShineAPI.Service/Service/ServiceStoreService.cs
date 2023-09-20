﻿using ShoeShineAPI.Core.IRepositories;
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
	public class ServiceStoreService : CommonAbstract<ServiceStoreEntity>, IServiceStoreService
	{
		IUnitRepository _unit;

		public ServiceStoreService(IUnitRepository unit)
		{
			_unit = unit;
		}

		public async Task<IEnumerable<ServiceStoreEntity>> GetServiceStoreAsync()
		{
			var serviceStores= await GetAllDataAsync();
			return serviceStores;
		}

		protected override async Task<IEnumerable<Core.Model.ServiceStoreEntity>> GetAllDataAsync()
		{
			return await _unit.ServiceStoreRepository.GetAll();
		}
	}
}

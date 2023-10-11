﻿using ShoeShineAPI.Core.IRepositories;
using ShoeShineAPI.Core.Model;
using ShoeShineAPI.Core.RequestModel;
using ShoeShineAPI.Core.ResponeModel;
using ShoeShineAPI.Service.Inheritance_Class;
using ShoeShineAPI.Service.Service.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShineAPI.Service.Service
{
	public class StoreService : CommonAbstract<Store>, IStoreService
	{
		IUnitRepository _unit;
        IServiceStoreService _service;
        ICategoryStoreService _category;
        IImageStoreService _image;

        public StoreService(IUnitRepository unit, IServiceStoreService service, ICategoryStoreService category, 
            IImageStoreService image)
        {
            _unit = unit;
            _service = service;
            _category = category;
            _image = image;
        }

        public async Task<IEnumerable<Store>> GetStoresAsync()
		{
			var stores= await GetAllDataAsync();
			return stores;
		}

		protected override async Task<IEnumerable<Core.Model.Store>> GetAllDataAsync()
		{
			return await _unit.StoreRepository.GetAll();
		}
        public async Task<(bool,string)> RegisterStoreAsync(Store store,StoreRequest request)
        {
            if (await CheckStoreEmailExistsAsync(store.StoreEmal,0))
            {
                return (false, "StoreEmail already exists");
            }
            // Save the new store to the database
            store.StoreRegisterDate= DateTime.Now;
            await _unit.StoreRepository.Add(store);
            var result= _unit.Save();
            if (result > 0)
            {
                var result_1 = await _category.AddCategoryStore(store.StoreId, request.CategoryArray);
                if (result_1.Item1)
                {
                    var result_2 = await _service.AddServiceStore(store.StoreId, request.ServiceArray,request.ServicePrice);
                    if (result_2.Item1)
                    {
                        if (await _image.CraeteImageStore(store.StoreId, request.Url))
                        {
                            return (true, "Create Store Success");
                        }
                        return (false, "Create ImageStore Fail");
                    }
                    return result_2;
                }
                return result_1;
            }
            return (false, "Create Store Fail");
        }
        
        public async Task<bool> CheckStoreEmailExistsAsync(string storeEmail,int storeId)
        {

            var stores = await GetAllDataAsync(); 
            return stores.Any(s => s.StoreEmal == storeEmail && s.StoreId!=storeId);
        }


        public async Task<IEnumerable<Store>> GetStoreByName(string storeName)
        {
            var stores = await _unit.StoreRepository.GetStoresByName(storeName);
            return stores;
        }

        
        public async Task RemoveAllStores()
        {
            var stores = await _unit.StoreRepository.GetAll();
            if (stores.Any())
            {
                var serviceStores = await _unit.ServiceStoreRepository.GetAll();
                if (serviceStores.Any())
                {
                    _unit.ServiceStoreRepository.RemoveRange(serviceStores);
                }
                _unit.StoreRepository.RemoveRange(stores);
                _unit.Save();
            }
        }
        public async Task<(bool,string)> UpdateStore(Store request, string[] url)
        {
            if(await CheckStoreEmailExistsAsync(request.StoreEmal,request.StoreId)) return (false, "Email is exist");
            if (request != null)
            {
                _unit.StoreRepository.Update(request);
                if(_unit.Save()>0)
                {
                    if (url.Length > 0)
                    {
                        var respone = await _image.UpdateImage(request.StoreId, url);
                        if (!respone.Item1) return respone;
                        return respone;
                    }
                    return (true, "Update Store Success");
                }
            }
            return (false,"Update Store Fail Because Nothing To Change");
        }
        public async Task<Store?> GetStoreById(int storeId)
        {
            return await _unit.StoreRepository.GetById(storeId);
        }

    }
}

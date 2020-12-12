using ApiColor.Api.DB;
using ApiColor.Data;
using ApiColor.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiColor.Service.Service
{
    public class Service
    {
        private readonly IRepository _IRepository;
        public Service(IRepository IRepository)
        {
            _IRepository = IRepository;
        }
        public async Task<bool> AddAsync(ColorEntity color)
        {
            try
            {
                var obj = new ColorEntity();
                obj.ColorName = color.ColorName;
                var result = await _IRepository.Add(obj);
                return result;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public async Task<bool> DeleteAsync(long id)
        {
            try
            {
                var result = await _IRepository.Delete(id);
                return result;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public async Task<List<ColorEntity>> GetAllAsync()
        {
            var userList = new List<ColorEntity>();
            var result = await _IRepository.GetAll();
            foreach (var item in result)
            {
                userList.Add(new ColorEntity
                {
                    Id = item.Id,
                    ColorName = item.ColorName,
                   
                });
            }
            return userList;
        }

        public async Task<ColorEntity> GetByIdAsync(long id)
        {
            var result = await _IRepository.GetById(id);
            var ColorEntity = new ColorEntity();
            ColorEntity.Id = result.Id;
            ColorEntity.ColorName = result.ColorName;
         
            return ColorEntity;
        }

        public async Task<bool> UpdateAsync(ColorEntity color)
        {
            try
            {
                var obj = new ColorEntity();
                obj.Id = ColorEntity.Id;
                obj.ColorName = ColorEntity.ColorName;
                var result = await _IRepository.Update(obj);
                return result;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}

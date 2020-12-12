using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApiColor.Data;


namespace ApiColor.Service.IService
{
    public interface IService
    {
        Task<bool> AddAsync(ColorEntity color);
        Task<bool> UpdateAsync(ColorEntity color);
        Task<List<ColorEntity>> GetAllAsync();
        Task<ColorEntity> GetByIdAsync(short id);
        Task<bool> DeleteAsync(short id);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApiColor.Api.DB;
using ApiColor.Repository.DB;

namespace ApiColor.Repository.IRepository
{
    public interface IRepositoryBase
    {
        Task<bool> Add(Color color);
        Task<bool> Update(Color color);
        Task<List<Color>> GetAll();
        Task<Color> GetById(short id);
        Task<bool> Delete(short id);
    }
}

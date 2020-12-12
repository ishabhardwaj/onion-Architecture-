using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ApiColor.Api.DB;
using ApiColor.Repository;
using ApiColor.Repository.DB;
using ApiColor.Repository.IRepository;

namespace ApiColor.Repository.Repository
{
    class RepositoryBase : IRepositoryBase
    {
        private readonly TestDBContext context;
        public RepositoryBase(TestDBContext context)
        {
            this.context = context;
        }
        public async Task<bool> Add(Color color)
        {
            try
            {
                await context.Color.AddAsync(color);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public async Task<bool> Delete(short id)
        {
            try
            {
                var result = await context.Color.Where(e => e.Id == id).FirstOrDefaultAsync();
                if (result != null)
                {
                    context.Color.Remove(result);
                    await context.SaveChangesAsync();
                }
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
             async Task<List<Color>> GetAll()
            {
                var result = await context.Color.ToListAsync();
                return result;
            }

             async Task<bool> Update(Color color)
            {
                try
                {
                    context.Color.Update(color);
                    await context.SaveChangesAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }

        }

        async Task<Color> GetById(short id)
        {
            var result = await context.Color.Where(e => e.Id == id).FirstOrDefaultAsync();
            return result;
        }

    }

}

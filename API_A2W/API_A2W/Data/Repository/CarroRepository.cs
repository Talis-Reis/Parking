using API_A2W.Data.Context;
using API_A2W.Domain.Entities;
using API_A2W.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_A2W.Data.Repository
{
    public class CarroRepository<TEntity> : ICarroRepository<TEntity> where TEntity : CarroEntity
    {

        protected readonly MyContext _context;

        private DbSet<TEntity> _dataset;

        public CarroRepository(MyContext context)
        {
            _context = context;
            _dataset = context.Set<TEntity>();
        }

        public async Task<TEntity> CreateCarro(TEntity carro)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(x => x.Id.Equals(carro.Id));
                if (result != null)
                {
                    carro.CreateAt = DateTime.UtcNow;
                    _dataset.Add(carro);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return carro;
        }

        public async Task<bool> RemoveCarro(int Id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(x => x.Id.Equals(Id));
                if (result != null)
                {
                    _dataset.Remove(result);
                    await _context.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> SelectAll()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> SelectCarroById(int Id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(x => x.Id.Equals(Id));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> UpdateCarro(TEntity carro)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(x => x.Id.Equals(carro.Id));
                if (result != null)
                {
                    carro.CreateAt = result.CreateAt;
                    carro.UpdateAt = DateTime.UtcNow;

                    _context.Entry(result).CurrentValues.SetValues(carro);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return carro;
        }
    }
}

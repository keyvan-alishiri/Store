using System.Threading.Tasks;
using System.Net.Mime;
using System;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
         IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
         Task<int> Complate();
    }
}
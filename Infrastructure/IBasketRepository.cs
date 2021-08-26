using System.Reflection.Metadata;
using System.Threading.Tasks;
using Core.Entities;

namespace Infrastructure
{
    public interface IBasketRepository
    {
         Task<CustomerBasket> GetBasketAsync(string basketId);
         Task<CustomerBasket> UpdateBasketAsync(CustomerBasket basket);
         Task<bool> DeleteBasketAsync(string basketId);
    }
}
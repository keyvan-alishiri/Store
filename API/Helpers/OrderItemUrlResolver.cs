using API.Dtos;

using Core.Entities.OrderAggregate;
using Microsoft.Extensions.Configuration;

namespace API.Helpers
{
    public class OrderItemUrlResolver : AutoMapper.IValueResolver<OrderItem, OrderItemDto, string>
    {
        private readonly IConfiguration _config;
        public OrderItemUrlResolver(IConfiguration config)
        {
            this._config = config;

        }



        public string Resolve(OrderItem source, OrderItemDto destination, string destMember, AutoMapper.ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.ItemOrdered.PictureUrl))
            { 
                return _config["ApiUrl"] + source.ItemOrdered.PictureUrl;
            }

            return null;

        }
    }
}
using System.Security.AccessControl;
using System.Runtime.Serialization;
namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Pending Received")]
        PaymentReceived,
         [EnumMember(Value = "Pending Failed")]
        PaymentFailed,
        

    }
}
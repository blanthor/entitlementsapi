using System.Collections.Generic;
namespace EntitlementsAPI.Models
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public int SubscriptionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SubscriptionDto> Subscriptions { get; set; }
    }
}

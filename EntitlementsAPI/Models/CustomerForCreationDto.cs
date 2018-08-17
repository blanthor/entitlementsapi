using System.Collections.Generic;

namespace EntitlementsAPI.Models
{
    public class CustomerForCreationDto
    {
        public int SubscriptionId { get; set; }
        public string Name { get; set; }

        public virtual List<SubscriptionDto> Subscriptions { get; set; }
    }
}

using System.Collections.Generic;

namespace EntitlementsAPI.Models   
{
    public class Pool
    {
        public int Id { get; set; }
        public int SubsId { get; set; }

        public virtual SubscriptionDto Subscription { get; set; }

        public virtual List<FullfillmentBucket> FullfillmentBuckets { get; set; }
    }
}

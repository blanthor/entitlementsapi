using System.Collections.Generic;

namespace EntitlementsAPI.Models
{
    public class Entitlement
    {
        public string LicenseId { get; set; }
        public string EntitlementId { get; set; }

        public CustomerDto Customer { get; set; }

        public List<Pool> Pools{ get; set; }

    }
}

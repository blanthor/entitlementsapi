using System;
using System.Collections.Generic;
using System.Text;

namespace EntitlementsAPI.Models
{
    public class MockDataStore
    {
        public List<CustomerDto> CustomerDtos { get; set; }

        public static MockDataStore Current = new MockDataStore();

        public MockDataStore()
        {
            CustomerDtos = new List<CustomerDto>()
            {
                new CustomerDto()
                {
                    Id=1,
                    Name = "CustomerDto 1",
                    SubscriptionId = 1,
                    Subscriptions = null
                },
                new CustomerDto()
                {
                    Id=2,
                    Name="CustomerDto 12",
                    SubscriptionId = 0,
                    Subscriptions = new List<SubscriptionDto>()
                    {
                        new SubscriptionDto()
                        {
                            Id=1,
                            Capacity=10,
                            LicenseId=11,
                            Resource="Resource 1, 10, 11"
                        }
                    }
                }
            };
        }
    }
}


/*

    
    
    
     
*/

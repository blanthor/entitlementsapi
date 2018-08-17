using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using entitlements.domain;
using EntitlementsAPI.Models;


namespace EntitlementsAPI.Controllers
{
    [Route("api/customer")]
    public class SubscriptionController : Controller
    {
        [HttpGet("{customerId}/subscriptions")]
        public IActionResult GetCustomerSubscriptions(int customerId)
        {
            var customer = MockDataStore.Current.CustomerDtos.FirstOrDefault(c => c.Id == customerId);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer.Subscriptions);
        }

        [HttpGet("{customerId}/subscriptions/{id}")]
        public IActionResult GetCustomerSubscription(int customerId, int id)
        {
            var customer = MockDataStore.Current.CustomerDtos.FirstOrDefault(c => c.Id == customerId);

            if (customer == null)
            {
                return NotFound();
            }

            var subscription = customer.Subscriptions.FirstOrDefault(s => s.Id == id);

            if (subscription == null)
            {
                return NotFound();
            }

            return Ok(subscription);
        }
    }
}
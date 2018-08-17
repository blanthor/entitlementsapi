using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using entitlements.domain;
using EntitlementsAPI.Models;

namespace EntitlementsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseController : Controller
    {
        //TODO: Put in LIcenseController

        /// <summary>
        /// Gets the license information.
        /// Input Fguid
        ///Output:
        ///License ID
        ///Customer ID
        ///SubscriptionDto ID
        ///Capacity
        /// </summary>
        /// 
        /// <returns></returns>
        //[HttpGet("api/licenses/{fguid}")]
        [HttpGet("{fguid}")]
        public JsonResult GetLicenseInfo(int fguid)
        {
            return new JsonResult(new List<object>()
            {
                new License()
                {
                    Id=1,
                    Fguid=new Guid(), //TODO change param to guid
                    SubsId=fguid
                }
            });
        }
    }
}
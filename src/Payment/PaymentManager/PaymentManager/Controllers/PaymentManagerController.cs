using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaymentManager.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentManagerController : ControllerBase
    {
        [HttpGet]
        [Route("ping")]
        public string Ping()
        {
            return "Payment Manager service is up & running !!";
        }

        [HttpGet]
        [Route("getPayment")]
        public string GetPayment()
        {
            return $"Payment reference number is 232321m3kenk2je30245";
        }
    }
}
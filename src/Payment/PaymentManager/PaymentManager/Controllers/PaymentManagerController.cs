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
            return "Payment Manager service is running OK!!";
        }
    }
}
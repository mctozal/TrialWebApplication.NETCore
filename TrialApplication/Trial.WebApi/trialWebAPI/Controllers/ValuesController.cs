using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trialBusiness;

namespace trialWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public ValuesController(IUserManager userManager)

        {
            _userManager = userManager;
        }
        // GET api/values
        [HttpGet]
        public trialData.ExampleModel Get()
        {
            return _userManager.GetExampleModel();
        }
        
       


    }
}

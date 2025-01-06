using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Add2NumbersEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2Numbers : ControllerBase
    {
         [HttpPost] 
        [Route("AddNumbers/{num1}/{num2}")] 
        
        public string AddNumbers (int num1, int num2)
        {
            int sum = num1+num2;
            return ($"The sum of {num1} and {num2} is {sum}.");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidAPI.Rules;

namespace ValidAPI.Controllers
{
    [ApiController]
    [Route("api/Validacao")]
    public class ValidacaoEmailController : ControllerBase
    {
        [HttpGet]
        [Route("Gmail/{mail}")]
        public IActionResult ValidarEmail(string mail, [FromServices] RegrasValidacao validator){
            if(validator.ValidarEmail(mail))
                return Ok(new RetornoValidacao("Email Válido!", mail, true));
            return Ok(new RetornoValidacao("Email Inválido!", mail, false));
        }
    }
}
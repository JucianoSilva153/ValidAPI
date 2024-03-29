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
    public class ValidacaoNumeroBI : ControllerBase
    {

        [HttpGet]
        [Route("BI/{numeroBI}")]
        public IActionResult ValidarNumeroBI(string numeroBI, [FromServices] RegrasValidacao validator){
            if(validator.ValidarBI(numeroBI))
                return Ok(new RetornoValidacao("Número de BI Válido!", numeroBI, true));
            return Ok(new RetornoValidacao("Número de BI Inválido!", numeroBI, false));
        }
    }
}
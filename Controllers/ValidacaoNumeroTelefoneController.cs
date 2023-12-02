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
    public class ValidacaoNumeroTelefoneController : ControllerBase
    {

        [HttpGet]
        [Route("AO/{numero}")]
        public IActionResult ValidarNumeroTelefoneAO(int numero, [FromServices] RegrasValidacao validator)
        {
            if(validator.ValidarNumeroTelefoneAO(numero))
                return Ok(new RetornoValidacao("Número de Telemóvel Válido!", numero, true));
            return Ok(new RetornoValidacao("Número de Telemóvel Inválido!", numero, false));
        }

        
    }
}
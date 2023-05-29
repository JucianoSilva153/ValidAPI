using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidAPI.Rules;

namespace ValidAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ValidacaoNumeroTelefoneController : ControllerBase
    {

        RegrasValidacao validator = new RegrasValidacao();

        [HttpGet]
        [Route("AO/{numero}")]
        public IActionResult ValidarNumeroTelefoneAO(int numero)
        {
            if(validator.ValidarNumeroTelefoneAO(numero))
                return Ok(new RetornoValidacao("Número de Telemóvel Válido!", numero, true));
            return Ok(new RetornoValidacao("Número de Telemóvel Inválido!", numero, false));
        }

        
    }
}
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
    public class ValidarSenhaController : ControllerBase
    {
        RegrasValidacao validator = new RegrasValidacao();

        [HttpGet]
        [Route("Senha/{maxChar}/{senha}")]
        public IActionResult ValidarSenha(int maxChar, string senha){
            if(validator.ValidarSenha(senha, maxChar))
                return Ok(new RetornoValidacao("Senha Válida!", senha, true));
            return Ok(new RetornoValidacao("Senha Inválida!", senha, false));
        }
    }
}
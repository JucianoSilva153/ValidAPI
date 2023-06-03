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
        [Route("Senha/{minChar}/{senha}")]
        public IActionResult ValidarSenha(int minChar, string senha){
            if(validator.ValidarSenha(senha, minChar))
                return Ok(new RetornoValidacao("Senha Válida!", senha, true));
            return Ok(new RetornoValidacao("Senha Inválida!", senha, false));
        }
    }
}
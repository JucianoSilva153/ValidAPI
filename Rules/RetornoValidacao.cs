using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidAPI.Rules
{
    public class RetornoValidacao
    {
        public string Mensagem { get; set; }
        
        public object Target { get; set; }
        
        public bool Validado { get; set; }

        public RetornoValidacao(string mensagem, object target, bool validado)
        {
            Mensagem = mensagem;
            Target = target;
            Validado = validado;
        }
        
    }
}
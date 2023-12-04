using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidAPI.Rules
{
    public class RegrasValidacao
    {
        //TODO: Adicionar Tratamento de Erro, quando os parametros forem null ou empty
        public bool ValidarNumeroTelefoneAO(int numero)
        {
            if (numero.ToString().Length == 9 && numero.ToString()[0] == '9')
                return true;
            return false;
        }
        public bool ValidarEmail(string mail)
        {
            var mailDividido = DivideEmail(mail);
            if (!(mailDividido is null))
            {
                if (ValidarParteLocalEmail(mailDividido[0]) && ValidarParteDominioEmail(mailDividido[1]))
                    return true;
            }
            return false;
        }
        private string[] DivideEmail(string email)
        {
            if (email.Contains("@"))
            {
                var componentesMail = email.Split('@');
                return componentesMail;
            }

            return new string[0];
        }
        private bool ValidarParteLocalEmail(string parteEmail)
        {
            string padraoEmailParteLoacal = @"^[a-zA-Z0-9._%+-]+$";
            if (Regex.IsMatch(parteEmail, padraoEmailParteLoacal))
                return true;
            return false;
        }
        private bool ValidarParteDominioEmail(string dominioEmail)
        {
            string padraoEmailDominio = @"^[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (Regex.IsMatch(dominioEmail, padraoEmailDominio))
                return true;
            return false;
        }
        public bool ValidarSenha(string senha, int minCarateres)
        {
            if (senha.Length >= minCarateres && VerificarSenhaSegura(senha, minCarateres))
                return true;
            return false;
        }
        private bool VerificarSenhaSegura(string senha, int minChar){
            string padraoSenha = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{"+ minChar + ",}$";
            if(Regex.IsMatch(senha, padraoSenha)){
                return true;
            }
            return false;
        }
        public bool ValidarBI(string BI)
        {
            if (BI.Length == 14
            && VerificarLetrasBI(BI))
                return true;
            return false;
        }
        private bool VerificarLetrasBI(string BI)
        {
            string padraoBI = @"^\d(9)[A-Z]{2}\d(3)$";
            if(Regex.IsMatch(BI, padraoBI))
                return true;
            return false;
        }

    }
}
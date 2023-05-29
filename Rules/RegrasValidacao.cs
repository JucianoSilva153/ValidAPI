using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidAPI.Rules
{
    public class RegrasValidacao
    {
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

        public string[] DivideEmail(string email)
        {
            if (email.Contains("@"))
            {
                var componentesMail = email.Split('@');
                return componentesMail;
            }

            return null;
        }

        public bool ValidarParteLocalEmail(string parteEmail)
        {
            if (parteEmail[0] != '.'
            && !parteEmail.Contains("..")
            && parteEmail.Length <= 64)
                return true;
            return false;
        }

        public bool ValidarParteDominioEmail(string dominioEmail)
        {
            if (dominioEmail.Length <= 63
            && dominioEmail[0] != '-'
            && dominioEmail[dominioEmail.Length - 1] != '-'
            && dominioEmail.Contains(".com"))
                return true;
            return false;
        }

        public bool ValidarSenha(string senha, int maxCarateres)
        {
            if (senha.Length <= maxCarateres && VerificarSenha(senha) && senha.Length >= 8)
                return true;
            return false;
        }

        public bool VerificarSenha(string senha)
        {
            if (!senha.Contains("=")
            && !senha.Contains("+")
            && !senha.Contains("-")
            && !senha.Contains("_")
            && !senha.Contains("*")
            && !senha.Contains(")")
            && !senha.Contains("(")
            && !senha.Contains("%")
            && !senha.Contains("^")
            && !senha.Contains("#")
            && !senha.Contains("~"))
                return true;
            return false;
        }

        public bool ValidarBI(string BI)
        {
            if (BI.Length == 14
            && VerificarLetrasBI(BI))
                return true;
            return false;
        }

        public bool VerificarLetrasBI(string BI)
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (BI[9].ToString().Contains(i))
                    for (char j = 'A'; j <= 'Z'; j++)
                    {
                        if (BI[10].ToString().Contains(j))
                            return true;
                    }
            }

            return false;
        }

    }
}
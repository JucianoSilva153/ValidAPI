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
            && dominioEmail.Contains(".com")
            && (dominioEmail.Contains("gmail") 
                || dominioEmail.Contains("outlook") 
                || dominioEmail.Contains("yahoo")
                || dominioEmail.Contains("yandex")
                || dominioEmail.Contains("icloud")
                || dominioEmail.Contains("gmail")
                || dominioEmail.Contains("mail")))
                return true;
            return false;
        }

        public bool ValidarSenha(string senha, int minCarateres)
        {
            if (senha.Length >= minCarateres && VerificarSenha(senha))
                return true;
            return false;
        }
        public bool VerificarSenha(string senha)
        {
            if (VerificarSenhaSegura(senha))
                return true;
            return false;
        }
        public bool VerificarSenhaSegura(string senha)
        {
            if(VerificarCaracteresEspeciaisEmSenhas(senha)
            && VerificarSenhaContemLetrasMaisculas(senha)
            && VerificarSenhaContemLetrasMinusculas(senha))
                return true;
            return false;
        }
        public bool VerificarSenhaContemLetrasMaisculas(string senha)
        {
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                for (int i = 0; i < senha.Length; i++)
                {
                    if (senha[i] == letra)
                        return true;
                }
            }
            return false;
        }
        public bool VerificarSenhaContemLetrasMinusculas(string senha)
        {
            for (char letra = 'a'; letra <= 'z'; letra++)
            {
                for (int i = 0; i < senha.Length; i++)
                {
                    if (senha[i] == letra)
                        return true;
                }
            }
            return false;
        }
        public bool VerificarCaracteresEspeciaisEmSenhas(string senha)
        {
            if (senha.Contains('#')
            || senha.Contains('-')
            || senha.Contains('+')
            || senha.Contains('[')
            || senha.Contains(']')
            || senha.Contains('*')
            || senha.Contains('~')
            || senha.Contains('_')
            || senha.Contains('@')
            || senha.Contains('#')
            || senha.Contains('?'))
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{

    public class AutenticacaoException : Exception
    {
        public AutenticacaoException(string message) : base(message)
        {

        }
    }


    public class UsuarioInvalidaException : AutenticacaoException
    {
        public UsuarioInvalidaException(string message) : base(message)
        {

        }
    }

    public class SenhaInvalidaException : AutenticacaoException
    {
        public SenhaInvalidaException(string message) : base(message)
        {

        }
    }

    public static class Autenticacao
    {
        public static void Autenticar(string user, string pass)
        {
            if(user != "admin") 
            {
                throw new UsuarioInvalidaException("Usuário inválido");
            }

            if (pass != "admin")
            {
                throw new SenhaInvalidaException("Senha inválida");
            }
        }
    }
}

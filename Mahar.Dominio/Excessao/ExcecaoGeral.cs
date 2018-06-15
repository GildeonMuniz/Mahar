using System;
using System.Collections.Generic;
using System.Text;

namespace Mahar.Dominio.Excessao
{
    public class ExcecaoGeral : Exception
    {
        public ExcecaoGeral() {
            throw new Exception();
        }

        public ExcecaoGeral(string mensagem)
            : base(mensagem) {

            throw new Exception(mensagem);

        }

        public ExcecaoGeral(string mensagem, Exception inner)
            : base(mensagem, inner)
        {
            throw new Exception(mensagem,inner);
        }
    }
}

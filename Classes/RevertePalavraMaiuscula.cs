using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.Classes
{
    public class RevertePalavraMaiuscula : Palavra
    {
        public RevertePalavraMaiuscula(string palavra) : base(palavra)
        {
        }

        public override string Reverte()
        {
            return string.Create(_palavra.Length, _palavra, (caracteres, palavra) =>
            {
                palavra.ToUpper().AsSpan().CopyTo(caracteres);
                caracteres.Reverse();
            });
        }
    }
}
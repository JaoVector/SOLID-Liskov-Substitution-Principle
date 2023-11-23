using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.Classes
{
    public class RevertePalavra : Palavra
    {
        public RevertePalavra(string palavra) : base(palavra)
        {
        }

        public override string Reverte() 
        {
            return string.Create(_palavra.Length, _palavra, (caracteres, palavra) => 
            {
                palavra.AsSpan().CopyTo(caracteres);
                caracteres.Reverse();
            });
        }
    }
}
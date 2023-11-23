using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.Classes
{
    public abstract class Palavra
    {
        protected readonly string _palavra;
        public Palavra(string palavra)
        {
            _palavra = palavra;
        }

        public abstract string Reverte();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControlWS
{
    public abstract class RazinaPristupa
    {
        private Pristup PR;

        public Pristup Pristup
        {
            get { return PR; }
            set { PR = value; }
        }

        private string Podaci="Početna vrijednost.";

        public string podaci
        {
            get { return Podaci; }
            set { this.Podaci = value ?? string.Empty; }
        }

        public abstract string pristup();
    }
}

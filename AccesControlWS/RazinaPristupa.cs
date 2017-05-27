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

        private string Podaci = "Povjerljivi podaci: asdkfdčajklgačjksdčfjačk";

        public string podaci
        {
            get { return Podaci; }
        }

        public abstract string pristup();
    }
}

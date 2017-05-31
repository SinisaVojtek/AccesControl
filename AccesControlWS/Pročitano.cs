using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControlWS
{
    class Pročitano: RazinaPristupa
    {
        public Pročitano(RazinaPristupa razina) : this(razina.podaci, razina.Pristup)
        {

        }

        public Pročitano(string podaci, Pristup razina)
        {
            this.Pristup = razina;
            this.podaci = podaci;
        }

        public override string pristup()
        {
            promijeniStatus();
            return string.Empty;
        }

        private void promijeniStatus()
        {
            Pristup.trenutniStatus = new Zabranjeno(this);
        }
    }
}

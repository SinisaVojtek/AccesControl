using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControlWS
{
    class Pročitano: RazinaPristupa
    {
        public Pročitano(RazinaPristupa razina):this(razina.Pristup)
        {

        }

        public Pročitano(Pristup razina)
        {
            this.Pristup = razina;
        }

        public override string pristup()
        {
            promijeniStatus();
            return podaci;
        }

        private void promijeniStatus()
        {
            Pristup.trenutniStatus = new Zabranjeno(this);
        }
    }
}

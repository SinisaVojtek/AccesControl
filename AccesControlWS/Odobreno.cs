using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControlWS
{
    class Odobreno : RazinaPristupa
    {
        public Odobreno(RazinaPristupa razina):this(razina.Pristup)
        {

        }

        public Odobreno(Pristup razina)
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
            Pristup.trenutniStatus = new Pročitano(this);
        }
    }
}

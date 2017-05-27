using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesControlWS
{
    public class Pristup
    {
        public RazinaPristupa trenutniStatus = null;

        public Pristup()
        {
            trenutniStatus = new Zabranjeno(this);
        }

        public void pristupiPodacima()
        {
            while(true)
            {
                Console.WriteLine(trenutniStatus.pristup());
            }
        }

    }
}

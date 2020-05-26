using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie_Objektowe
{
   public class ZmianaNazwyEventArgs:EventArgs
    {
        public String IstniejacaNazwa { get; set; }
        public String NowaNazwa { get; set; }
    }
}

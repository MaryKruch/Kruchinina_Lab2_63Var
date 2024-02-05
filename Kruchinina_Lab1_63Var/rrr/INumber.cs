using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruchinina_Lab1_63Var.rrr
{
    interface INumber 
    {
        INumber Add(INumber n);
        INumber Sub(INumber n);
        INumber Mult(INumber n);
        INumber Div(INumber n);
    }
}

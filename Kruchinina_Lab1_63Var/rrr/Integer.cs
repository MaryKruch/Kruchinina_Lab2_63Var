using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruchinina_Lab1_63Var.rrr
{
    class Integer : INumber
    {
        public int A { get; set; }

        public INumber Add(INumber n)
        {
            Integer? chis = n as Integer;
            return new Integer() { A = this.A + chis!.A };
        }

        public INumber Div(INumber n)
        {
            Integer? chis = n as Integer;
            return new Integer() { A = this.A / chis!.A };
        }

        public INumber Mult(INumber n)
        {
            Integer? chis = n as Integer;
            return new Integer() { A = this.A * chis!.A };
        }

        public INumber Sub(INumber n)
        {
            Integer? chis = n as Integer;
            return new Integer() { A = this.A - chis!.A };
        }

        public override string? ToString()
        {
            return A.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruchinina_Lab1_63Var.rrr
{
    class Real : INumber
    {
        public double A { get; set; }
        
        public INumber Add(INumber n)
        {
            Real? chis = n as Real;
            return new Real() { A = this.A + chis!.A };
        }

        public INumber Div(INumber n)
        {
        Real? chis = n as Real;
        return new Real() { A = this.A / chis!.A };
        }

    public INumber Mult(INumber n)
        {
            Real? chis = n as Real;
            return new Real() { A = this.A * chis!.A };
        }

        public INumber Sub(INumber n)
        {
            Real? chis = n as Real;
            return new Real() { A = this.A - chis!.A };
        }
        public override string? ToString()
        {
        return A.ToString("F2");
        }
    }
 }
using System;
using System.Collections.Generic;
using System.Text;

namespace TasitLib
{
    public class Araba : Tasit
    {

        public Araba() { }

        public Araba(string marka, int model, int motor, string vites, string renk):
            base( marka, model, renk)
        {
            this.Motor = motor;
            this.Vites = vites;
        }

        private int Motor { get; set; }
        private string Vites { get; set; }


        public override string getTasitInfo()
        {
            return base.getTasitInfo() + $"Motor: {this.Motor}\nVites: {this.Vites}";
        }

    }
}

using System;

namespace TasitLib
{
    public abstract class Tasit
    {
        public Tasit() { }
        public Tasit(string marka, int model,int motor, string vites, string renk)
        {
            this.Marka = marka;
            this.Model= model;
            this.Motor = motor;
            this.Vites = vites;
            this.Renk = renk;

        }

        protected Tasit(string marka, int model, string renk)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
        }

        private string Marka { get; set; }
        private int Model { get; set; }
        private int Motor { get; set; }
        private string Vites { get; set; }
        private string Renk { get; set; }


        public virtual string getTasitInfo()
        {
            return $"Marka: {this.Marka}\nModel: {this.Model}\nMotor: {this.Motor}\nVites: {this.Vites}\nRenk: {this.Renk}";
        }
    }
}

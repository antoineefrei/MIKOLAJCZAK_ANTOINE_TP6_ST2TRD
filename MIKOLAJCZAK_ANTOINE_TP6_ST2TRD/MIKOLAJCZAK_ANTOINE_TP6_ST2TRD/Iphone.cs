using System;


namespace MIKOLAJCZAK_ANTOINE_TP6_ST2TRD
{
    public class Iphone : Assemblage

    {
        public virtual Iphone creationIphone()
        {
            return new Iphone();
        }

        public void Assemblage()
        {
         Console.WriteLine("Iphone is in creation ");   
        }

        public void activation()
        {
            Console.WriteLine("Iphone is switching On :");
        }
    }

    public class Iphone5 : Iphone
    {
        public override Iphone creationIphone()
        {
            return new Iphone5();
        }

        public new void Assemblage()
        {
            Console.WriteLine("Iphone5 is in creation ");   
        }

        public new void activation()
        {
            Console.WriteLine("Iphone5 is switching On :");
        }

        public Iphone5()
        {
            this.Assemblage();
            this.activation();
        }
    }
}
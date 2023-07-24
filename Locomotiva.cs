using System;
namespace lab5ex2
{
    public class Locomotiva
    {
        private int putere=0;
        public Tren tren = null;



        public Locomotiva(int putere)
        {
            this.putere = putere;
        }

        public int Putere { get; set; }


        public void AtaseazaLaTren(Tren tren)
        {
            this.tren = tren;
        }



        public void Pornestelocomotiva()
        {
            Console.WriteLine("A pornit locomotiva");
        }

        public void OpresteLocomotiva()
        {
            Console.WriteLine("S-a oprit locomotiva");
        }




    }
}

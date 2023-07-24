using System;
namespace lab5ex2
{
    public class VagonClasaIntai:VagonDePersoane
    {
      
        public VagonClasaIntai(int nrLocuri, int masa, int anulFabricatiei) : base(nrLocuri, masa, anulFabricatiei)

        {
        }


        public void PornesteAC()
        {
            Console.WriteLine("A pornit aerul conditionat");
        }

        public void OpresteAC()
        {
            Console.WriteLine("S-a oprit aerul conditionat");
        }
    }
}

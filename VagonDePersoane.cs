using System;
namespace lab5ex2
{
    public class VagonDePersoane:Vagon
    {
        protected int nrLocuri=0;


        public VagonDePersoane (int nrLocuri, int masa, int anulFabricatiei): base(masa, anulFabricatiei)
        {
            this.nrLocuri = nrLocuri;
        }

        public int NrLocuri { get; set; }
        
        public void InchideUsile()
        {
            Console.WriteLine("S-au inchis usile");
        }

        public void DeschideUsile()
        {
            Console.WriteLine("S-au deschis usile");
        }
    }
}

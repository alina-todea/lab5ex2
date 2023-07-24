using System;
namespace lab5ex2
{
    public class Vagon
    {
        protected int masa=0;
        protected int anulFabrictiei=0;
        public Tren tren = null;


        public Vagon(int masa, int anulFabricatiei)
        {
            this.masa = masa;
            this.anulFabrictiei = anulFabricatiei;
        }

        
        public int Masa { get; set; }
        

        public int AnulFabricatiei { get; set; }

        public void AtaseazaLaTren(Tren tren)
        {
            this.tren = tren;
        }

    }
}

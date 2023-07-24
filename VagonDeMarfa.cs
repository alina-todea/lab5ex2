using System;
namespace lab5ex2
{
    public class VagonDeMarfa:Vagon
    {
        private readonly TipMarfa tipMarfa;
        private int capacitate=0;


        public VagonDeMarfa(TipMarfa tipMarfa, int capacitate, int masa, int anulFabricatiei) : base(masa, anulFabricatiei)

        {
            this.tipMarfa = tipMarfa;
            this.capacitate = capacitate;
        }

        public int Capacitate { get; set; }
        

        public TipMarfa TipMarfa { get; set; }
       
    }
}

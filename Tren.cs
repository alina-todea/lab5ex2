using System;
using System.Collections.Generic;

namespace lab5ex2
{
    public class Tren
    {
        private string nume = string.Empty;
        private Locomotiva locomotiva= null;
        private Vagon vagon;
        private VagonDeMarfa vagonDeMarfa;
        private VagonDePersoane vagonDePersoane;
        private VagonClasaIntai vagonClasaIntai;
        List<Vagon> listaVagoane = new List<Vagon>();


        //public Tren(string nume, Locomotiva locomotiva, Vagon vagon)
        public Tren(string nume)

        {
            this.nume = nume;
            //this.locomotiva = locomotiva;
            //this.vagon = vagon;
            
        }

        public string Nume { get; set; }


        public void AdaugaVagonDeMarfa(VagonDeMarfa vagonDeMarfa)
        {
            listaVagoane.Add(vagonDeMarfa);
            vagonDeMarfa.AtaseazaLaTren(this);

        }

        public void AdaugaVagonDePersoane(VagonDePersoane vagonDePersoane)
        {
            listaVagoane.Add(vagonDePersoane);
            vagonDePersoane.AtaseazaLaTren(this);
        }

        public void AdaugaVagonClasaIntai(VagonClasaIntai vagonClasaIntai)
        {
            listaVagoane.Add(vagonClasaIntai);
            vagonClasaIntai.AtaseazaLaTren(this);
        }

        

        public void PleacaDinGara()
        {
            vagonDePersoane.InchideUsile();
            locomotiva.Pornestelocomotiva();
        }

        public void OpresteInGara()
        {
            locomotiva.OpresteLocomotiva();
            vagonDePersoane.DeschideUsile();
            vagonClasaIntai.OpresteAC();
        }

    }
}

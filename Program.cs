using System;

namespace lab5ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Tren tren1 = new Tren("intercity");
            Locomotiva diesel = new Locomotiva(1500);


            VagonDeMarfa vagon1 = new VagonDeMarfa(TipMarfa.Cereale, 1500, 5000, 2005);
            VagonDeMarfa vagon2 = new VagonDeMarfa(TipMarfa.Otel, 2000,5000, 2010);
            VagonClasaIntai vagon3 = new VagonClasaIntai(60, 4500, 2011);
            VagonClasaIntai vagon4 = new VagonClasaIntai(60, 4500, 2014);
            VagonDePersoane vagon5 = new VagonClasaIntai(80, 4500, 2001);
            VagonDePersoane vagon6 = new VagonClasaIntai(80, 4500, 2001);


            tren1.AdaugaVagonClasaIntai(vagon3);
            tren1.AdaugaVagonClasaIntai(vagon4);
            tren1.AdaugaVagonDeMarfa(vagon1);
            tren1.AdaugaVagonDeMarfa(vagon2);
            tren1.AdaugaVagonDePersoane(vagon5);
            tren1.AdaugaVagonDePersoane(vagon6);

            vagon5.InchideUsile();//asta da rezultat

            tren1.PleacaDinGara();//astea dau eroare de null
            tren1.OpresteInGara();


        }
    }
}

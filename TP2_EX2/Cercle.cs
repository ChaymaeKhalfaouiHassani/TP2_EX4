using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_EX2
{
   
        class Cercle
    {
        private Point centre;                   // Attribut de type Point
        private double rayon;
        public Cercle()//constructeur par defaut
        {
        }
        public Cercle(Point c, double r)   //Le constructeur d'initialisation
        {
            centre = c;
            rayon = r;
        }
        public Point getCentre()         //Le getter du centre
        {
            return centre;
        }
        public void setCenter(Point c)   //Le setter du centre
        {
            centre = c;
        }
        public double getRayon()         //Le getter du rayon
        {
            return rayon;
        }
        public void setRayon(double r)   //Le setter du rayon
        {
            rayon = r;
        }
        public void égalité(Cercle C1,Cercle C2)
        {
            if ((C1.centre == C2.centre) && (C1.rayon == C2.rayon))
            {
                Console.WriteLine("les deux cercles sont egaux");
            }else
                Console.WriteLine("les deux cercles ne sont pas egaux");
        }
        public void intersection(Cercle C1,Cercle C2)
        {
                    
        }
        public double circonférence()
        {
            return Math.Round(2 * Math.PI * rayon);            
        }
        public double Aire()
        {
            return Math.Round( Math.PI * rayon * rayon);
        }
        static void Main(string[] args)
        {
            Cercle C1 = new Cercle();
            Cercle C2 = new Cercle();
            Console.WriteLine("la valeur du rayon du 1ere cercle :");
            C1.rayon=double.Parse(Console.ReadLine());
            Console.WriteLine("le centre du 1ere cercle :");
            //C1.centre.setOrdonne=int.Parse(Console.ReadLine());
            Console.WriteLine("la valeur du rayon du 1ere cercle :");
            C2.rayon = double.Parse(Console.ReadLine());
            //C2.centre.setOrdonne=int.Parse(Console.ReadLine());

        }

    }
}

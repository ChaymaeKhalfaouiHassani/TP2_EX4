using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_EX2
{
    class Droite
    {
        private Point point1;            //L'attribut Point1
        private Point point2;             //L'attribut Point2
        public Droite()//constructeur par defaut
        {
        }
        public Droite(Point P1, Point P2)   //Le constructeur d'initialisation
        {
            point1 = P1;
            point2 = P2;
        }
        public Point getPoint1()         //Le getter du point1
        {
            return point1;
        }
        public void setPoint1(Point P1)   //Le setter du point1
        {
            point1 = P1;
        }
        public Point getPoint2()          //Le getter du point2
        {
            return point2;
        }
        public void setPoint2(Point P2)    //Le setter du point2
        {
            point2 = P2;
        }
        public void égalité(Droite D1,Droite D2) //la methode egalite
        {
            if ((D1.point1 == D2.point1) && (D1.point2==D2.point2))
            {
                Console.WriteLine("les 2 droites sont egaux");
            }
            else
            {
                Console.WriteLine("les 2 droites ne sont pas egaux");
            }
        }
        public void parallélisme(Droite D1, Droite D2)
        { }
            public void intersection(Droite D1, Droite D2) //la methode intersection
        {
            if((D1.point1==D2.point1)||(D1.point1 == D2.point2)||(D1.point2 == D2.point1)||(D1.point2 == D2.point2))
            {
                Console.WriteLine("les deux droites ont un point d'intarcection");
            }else
                Console.WriteLine("les deux droites n'ont pas un point d'intarcection");
        }
        public void perpendicularité(Droite D1, Droite D2)
        {
     
        }
        static void Main(string[] args)
        { 
            Droite D1 = new Droite();
            Droite D2 = new Droite();
            
            
        }

    }
}

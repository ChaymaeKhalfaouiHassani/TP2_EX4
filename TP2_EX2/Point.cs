using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_EX2
{
    public class Point
    {
        private double Abs;            //L'attribut Abscisse
        private double Ord;             //L'attribut Ordonne
        public Point()//constructeur par defaut
        {
        }
        public Point(double a, double o)   //Le constructeur d'initialisation
        {
            Abs = a;
            Ord = o;
        }
        public double getAbs()         //Le getter de l'attribut Abscisse
        {
            return Abs;
        }
        public void setAbs(double a)   //Le setter de l'attribut Abscisse
        {
            Abs = a;
        }
        public double getOrd()          //Le getter de l'attribut Ordonne
        {
            return Ord;
        }
        public void setOrdonne(double o)    //Le setter de l'attribut Ordonne
        {
            Ord = o;
        }
    }
  }

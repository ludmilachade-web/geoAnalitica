using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geoAnalitica
{
    internal class Recta
    {
        private Punto p1;
        private Punto p2;

        public Recta(Punto p1, Punto p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public Recta() 
        {
        }
        internal Punto P1 { get => p1; set => p1 = value; }
        internal Punto P2 { get => p2; set => p2 = value; }

        //crear metodo distancia
        //con public
        public float distancia()
        {
            //dividirlo en variables para que no quede tan raroXD ni tan largo
            float d;
            float difx;
            float dify;
            Double sum;
            difx = this.P2.X - this.P1.X;
            dify = this.P2.Y - this.P1.Y;
            sum = (Math.Pow(difx,2)+Math.Pow(dify,2));
            d =Convert.ToSingle(Math.Sqrt(sum));
            return d;
            
        }
    }
}


//OBJETO DE LA CLASE RECTA Y UNO DE LA CLASE PUNTO Y COLOCARLO EN 
//KATIA SARAÍ GARCÍA MARTÍNEZ :)
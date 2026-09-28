using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geoAnalitica
{
    internal class Punto
    {
        private float x;//propiedad
        private float y;//propiedad

        public Punto()//metodo constructor
        {
        }
        public Punto(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X { get =>x ; set => x = value; }
        public float Y { get =>y ; set => y = value; }

       
    }

}

//KATIA SARAÍ GARCÍA MARTÍNEZ :)


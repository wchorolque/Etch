using System;

namespace Model
{
    public class Pais
    {
        public string Codigo {
            get;
            set;
        }

        public string Nombre {
            get;
            set;
        }

        public Pais ()
        {
        }

        public override string ToString ()
        {
            return Nombre;
        }
    }
}


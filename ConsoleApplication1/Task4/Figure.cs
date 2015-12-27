using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    abstract class Figure : Drawing
    {
        protected int x { get; set; }
        protected int y { get; set; }
        public abstract void showInConsole();
        //public abstract bool equalsTwoObjects(Figure other);
        public abstract double square();

        public override bool Equals(object other)
        {

            
            if (this == other)
            {
                return true;
            }

            if (other is Figure)
            {
                Figure otherFigura = (Figure) other;

                if (this.x == otherFigura.x && this.y == otherFigura.y)
                {
                    return true;
                }

                return false;
            }


            return false;
        }
    }
}

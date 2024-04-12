using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {    
        private readonly Color color;
        private float radius;
        private int nTimesThrown;

        public Sphere(Color c, float r)
        {
            color = c;
            radius = r;
            nTimesThrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                nTimesThrown += 1;
            }
        }

        public int GetTimesThrown()
        {
            return nTimesThrown;
        }
    }
}
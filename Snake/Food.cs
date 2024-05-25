using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {

        public Point Location { get; private set;}

        public void CreateFood()
        {
            Random rnd = new Random();
            Location = new Point(rnd.Next(0,27), rnd.Next(0, 27));
        }

    }
}

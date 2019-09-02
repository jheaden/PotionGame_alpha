using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionGame
{
    class Red_Potion : IPotion
    {
        public void Affect()
        {
            Console.WriteLine("Without hesitating, you drink the red potion. There is a flash of light and you feel a little queasy.");
            Console.WriteLine("Then you notice that you have turned into a cat.");
        }

     
    }
}

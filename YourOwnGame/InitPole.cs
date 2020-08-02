using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourOwnGame
{
    class InitPole
    {
        public static int[] initNewGame()
        {
            int[] numLabel = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                numLabel[i] = i + 1;
            }

            for (int i = 0; i < 100; i++)
            {
                int j = rnd.Next(i + 1);
                if (j != i)
                {
                    int tmp = numLabel[i];
                    numLabel[i] = numLabel[j];
                    numLabel[j] = tmp;
                }
            }
            return numLabel;
        }

        public static int rndSampling()  
        {
            Random rnd = new Random();

            int rndLbl = rnd.Next(1, 100);

            return rndLbl;
        }
    }
}

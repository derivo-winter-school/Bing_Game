using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bingo_Game_Mark_1.Classes
{
    public class Randomize
    {

        public int Random()
        {
                Random R = new Random();
                int num = R.Next(1, 91);
            return num;

          
        }


    }
}
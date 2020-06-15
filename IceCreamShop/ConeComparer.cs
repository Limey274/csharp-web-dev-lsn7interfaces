using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)    //so this works
        {

            if (x.Cost - y.Cost > 0)
            {
                return (1);
            }
            else if (x.Cost - y.Cost < 0)
            {
                return -1;
            }
            else return 0;



            //return Convert.ToInt32((y.Cost - x.Cost));

            // return Convert.ToInt32((x.Cost - y.Cost) * -1);
        }
    }
}

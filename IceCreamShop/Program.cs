using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            
            FlavorComparer comparer = new FlavorComparer();


            availableFlavors.Sort(comparer);


            for (int i = 0; i < availableFlavors.Count; i++)
            {
                Console.WriteLine(availableFlavors[i]);
            }



            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            ConeComparer comparer2 = new ConeComparer();
            availableCones.Sort(comparer2);


            // availableCones.Sort((x, y) => x.Cost.CompareTo(y.Cost));   //How moe would do it...



            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            for (int i = 0; i < availableCones.Count; i++)
            {
                Console.WriteLine(availableCones[i].ToString()); 
         }

            



       }
    }
}

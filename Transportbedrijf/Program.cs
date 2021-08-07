using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportbedrijf
{
    class Program
    {
        static void Main(string[] args)
        {
            // parameters
            bool solid; double volume; double weight; double perKM = 0;
            double km; double outkm; double inkm; double kmCost;
            double border = 0; double totalCost;

            // registration
            while (true)
            {
                Console.WriteLine("Is the substance liquid?");
                if (Console.ReadLine() == "yes"){solid = false;break;}
                else{solid = true;break;}
            }
            while (true)
            {
                try{Console.WriteLine("Please enter the total volume of the product");
                    volume = Convert.ToDouble(Console.ReadLine());break;}
                catch (Exception){Console.WriteLine("Invalid: please try again");}
            }
            while (true)
            {
                try{Console.WriteLine("Please enter the total weight of the product");
                    weight = Convert.ToDouble(Console.ReadLine());break;}
                catch (Exception){Console.WriteLine("Invalid: please try again");}
            }
            while (true)
            {
                try{Console.WriteLine("How many km were driven?");
                    km = Convert.ToDouble(Console.ReadLine());break;}
                catch (Exception){Console.WriteLine("Invalid: please try again");}
            }
            while (true)
            {
                try{Console.WriteLine("How many km were driven outside the Netherlands?");
                    outkm = Convert.ToDouble(Console.ReadLine());break;}
                catch (Exception){Console.WriteLine("Invalid: please try again");}
            }

            // math
            if (solid == true){perKM = (volume * 0.8) + (weight * 0.55);}
            else if (solid == false){perKM = (volume * 1.25) + (weight * 0.45);}
            Console.WriteLine("per km: " + perKM);

            inkm = km - outkm; outkm = outkm * 1.45; kmCost = (outkm * perKM) + (inkm * perKM);
            Console.WriteLine("kmCost: " + kmCost);

            if (outkm > 0)
            {
                border = perKM * 3.5 / 100;
                if (border < 45){border = 45;}
            }
            Console.WriteLine("border cost: " + border);
            totalCost = kmCost + border;
            Console.WriteLine("The total cost is: " + totalCost);
        }
    }
}

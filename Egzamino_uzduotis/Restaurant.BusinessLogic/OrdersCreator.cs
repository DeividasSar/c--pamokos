using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.BusinessLogic
{
    public class OrdersCreator
    {
        public OrdersCreator()
        { }
        public static int InputIsNumber()
        {
            int num;
            do
            {
            } while (!int.TryParse(Console.ReadLine(), out num));
            {
                int OnlyNum = num;
                return OnlyNum;
            }
        }
        public static void BadInput()
        {
            Console.WriteLine("Blogas input, bandykite dar kartą");
        }
    }

}

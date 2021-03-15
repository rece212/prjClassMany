using System;

namespace prjClassMany
{
    class Program
    {
        static void Main(string[] args)
        {
            items i = new items();

            Console.Write("Please enter the shops name :");
            i.setShopName(Console.ReadLine());

            Console.Write("Please enter the cell number :");
            i.setCellNumber(Console.ReadLine());


            Console.Write("Please enter the amount of products :");
            i.setArray(Convert.ToInt32(Console.ReadLine()));
            

            capture c = new capture();
            c.getProductDetails();

            print_Items p = new print_Items();
            p.printReports();




        }
    }
}

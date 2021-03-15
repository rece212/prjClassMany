using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassMany
{
    class capture
    {
        public void getProductDetails()
        {
            items i = new items();

            Console.Clear();

            for (int x = 0; x < i.size(); x++)
            {
                Console.WriteLine( "Please enter the product name "+(x+1)+" :");
                String strProduct = Console.ReadLine();

                Console.WriteLine("Please enter price for "+strProduct+" R:");
                double dblPrice = Convert.ToDouble(Console.ReadLine());

                i.setProduct(strProduct);
                i.setPrice(dblPrice);

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Seller
    {
        public void Sell(string product, Buyer buyer) /// создаем метод продажи
        {
            if (product == "алкоголь" && buyer.Age < 18)
            {
                throw new SaleException("Продажа запрещена!"); /// выброс исключения
            }

            Console.WriteLine("Товар продан");
        }
    }
}

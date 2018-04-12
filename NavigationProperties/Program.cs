using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationProperties
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ShopContext())
            {
                // 3 типа загрузки по навигационным свойствам
                // 1 тип жадная загрузка
                // 2 тип явная загрузка
                // 3 тип ленивая загрузка


                //1 способ
                //IList<Order> eagerOrders = context.Orders.Include(order => order.Person).ToList();

                ////2 способ
                //IList<Order> orders = context.Orders.ToList();
                //context.Entry(orders[0]).Reference("Person").Load();

                //3 способ
                IList<Order> orders = context.Orders.ToList();
            }
        }
    }
}

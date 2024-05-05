using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities;
using Course.Entities.Enums;


namespace Course {
    class Program {
        static void Main(string[] args) {

            Order order = new Order{

                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered

            };

        Console.WriteLine(order);

        string txt = OrderStatus.PendingPayment.ToString();

        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        Console.WriteLine(txt);
        Console.WriteLine(os);

        int statusNumber = (int)order.Status;
        Console.WriteLine($"N° {statusNumber}");

        }

    }

}
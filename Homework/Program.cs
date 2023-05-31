using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int money;
            int food;
            int foodUnitPrice = 10;
            bool isAbleToPay;

            Console.WriteLine("Добро пожаловать в пекарню! Сегодня еда по " + foodUnitPrice + " монет");
            Console.Write("Сколько у вас золота?");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам нужно?");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * foodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodUnitPrice;
            if (money < foodUnitPrice)
            {
                Console.WriteLine("Снимаем деньги... Выдаём еду... Успешно!");
                Console.WriteLine($"Вы получили +{food} еды. Денег в вашей сумке - {money}");
            }
            else
            {
                Console.WriteLine("Операция невыполнима. Проверьте правильность ввода данных. Возможно у вас недостаточно средств для покупки.");
            }
            Console.ReadLine();
        }
    }
}
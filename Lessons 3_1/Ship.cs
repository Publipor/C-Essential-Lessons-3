/*
Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). 
Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів та порт приписки. 
Написати програму, яка виводить на екран інформацію про кожен засіб пересування. 
 */

namespace VehiclesApp
{
    class Ship : Vehicle
    {
        public int PassengerCapacity { get; set; }
        public string HomePort { get; set; }

        public Ship(double x, double y, double price, double speed, int year, int passengerCapacity, string homePort)
            : base(x, y, price, speed, year)
        {
            PassengerCapacity = passengerCapacity;
            HomePort = homePort;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Пасажиромісткість: {PassengerCapacity}, Порт: {HomePort}");
        }
    }
}
    

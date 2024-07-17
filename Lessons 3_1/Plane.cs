/*
Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). 
Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів та порт приписки. 
Написати програму, яка виводить на екран інформацію про кожен засіб пересування. 
 */

namespace VehiclesApp
{
    class Plane : Vehicle
    {
        private double altitude; // 6.ініціалізація поля
        private int passengerCapacity; // 7.ініцілізація поля

        public double Altitude   // 8.створення методу 
        { 
            get
            {
                return altitude; // 8.1.повернення з методу знаення altitude 
            }
            set
            { 
                altitude = value; // 8.2.присвоювання змінній значень які передались методу
            }
        }
        public int PassengerCapacity // 9.створення методу
        {
            get
            {
                return passengerCapacity; // 9.1.повернення з методу знаення passengerCapacity 
            }

            set
            {
                passengerCapacity = value; // 9.2.повернення з методу знаення passengerCapacity 
            }
        }

        public Plane(double x, double y, double price, double speed, int year, double altitude, int passengerCapacity) // 2. Ініціалізація користувацького конструктора користувацькими значенням 
            : base(x, y, price, speed, year) // 3. Виклик базового конструктора (Vehicle) для ініціалізації його користувацькими данними
        { //5 . піся ініціалізації батьківського конструктора переходжу в дочірній
            Altitude = altitude;  // 5.1 ініціалізація поля Altitude з дочірного конструктора користувацькими значеннями altitude
            PassengerCapacity = passengerCapacity; // 5.2 ініціалізація поля  PassengerCapacity з дочірного конструктора користувацькими значеннями passengerCapacity
        }

        public override void DisplayInfo() // 10.створення поблічного методу який перевизначає метод з батьківського  класу
        {
            base.DisplayInfo(); // 10.1 виклик методу DisplayInfo з батьківського методу
            Console.WriteLine($"Altitude: {Altitude}, Пасажиромісткість: {PassengerCapacity}"); // 10.2 вивід в консоль значень полів Altitude, PassengerCapacity
        }
    }
}
    

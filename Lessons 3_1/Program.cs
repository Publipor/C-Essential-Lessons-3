/*
Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). 
Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів та порт приписки. 
Написати програму, яка виводить на екран інформацію про кожен засіб пересування. 
 */

namespace VehiclesApp
{
    public class Vehicle
    {
        private double xCoordinate;
        private double yCoordinate;
        private double price;
        private double speed;
        private int year;

        public double XCoordinate
        {
            get
            {
                return xCoordinate;
            }
            set
            {
                xCoordinate = value;
            }
        }

        public double YCoordinate
        {
            get
            {
                return yCoordinate;
            }
            set
            {
                yCoordinate = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public Vehicle(double x, double y, double price, double speed, int year) // 4. ініціалізація конструктора шляхом конструкції : base передача користувацьких параметрів
        {
            XCoordinate = x; //4.1 присвоювання полю ( єкземпляру) значення з конструктора 
            YCoordinate = y; //4.2 аналогічно
            Price = price; // 4.3 -//-
            Speed = speed; // 4.5 -//-
            Year = year; // 4.6 -//-
            //5 . піся ініціалізації батьківського конструктора переходжу в дочірній 
        }

        public virtual void DisplayInfo() // 10.1 Виклик методу за допомогою конструкції base
        {
            Console.WriteLine($"Координати: ({XCoordinate}, {YCoordinate}), Ціна: {Price}, Швидкість: {Speed}, Рік: {Year}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(10, 20, 500000, 900, 2015, 10000, 180); // 1.вииклик методу(конструктора методу) Plane, виділення та створення для нього місця в пам'яті, запис посилання з зінній plane. Передаю значення в конструктор методу
            Car car = new Car(30, 40, 30000, 200, 2018);
            Ship ship = new Ship(50, 60, 1000000, 30, 2010, 300, "Порт Одеса");

            plane.DisplayInfo(); // 10.1
           Console.WriteLine(); // 10.2

            car.DisplayInfo();
            Console.WriteLine();

            ship.DisplayInfo();
            Console.WriteLine();
        }
    }
}
    

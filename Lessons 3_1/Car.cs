/*
Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). 
Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів та порт приписки. 
Написати програму, яка виводить на екран інформацію про кожен засіб пересування. 
 */

namespace VehiclesApp
{
    class Car : Vehicle
    {
        public Car(double x, double y, double price, double speed, int year)
           : base(x, y, price, speed, year)
        {
            
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
    

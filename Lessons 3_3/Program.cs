/*
 *Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 *Потрібно: Створити клас Printer. У тілі класу створіть метод void Print(string value), що виводить на екран значення аргументу. 
 *Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів, та виклику відповідного методу їх екземпляра, рядки, передані як аргументи методів, виводилися різними кольорами. Обов'язково використовуйте типи.
 */
using System.Globalization;

class Printer
{
   public virtual void Print(string value)
        
    {
        Console.WriteLine(value);
    }
}
class RedPrinter : Printer
{
    public override void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        base.Print(value);
        Console.ResetColor();
    }
}

// Клас-нащадок GreenPrinter, який змінює колір тексту на зелений
class GreenPrinter : Printer
{
    public override void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        base.Print(value);
        Console.ResetColor();
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Printer print = new Printer();
        print.Print("Hello, White World!");

        RedPrinter print_RedPrinter = new RedPrinter();
        print_RedPrinter.Print("Hello, Red World!");

        GreenPrinter print_GreenPrinter = new GreenPrinter();
        print_GreenPrinter.Print("Hello, Green World!");




    }
}
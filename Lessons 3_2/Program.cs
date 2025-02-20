﻿/*
Використовуючи Visual Studio, створіть проект за шаблоном Console Application, потрібно створити клас DocumentWorker. 
У тілі класу створіть три методи OpenDocument(), EditDocument(), SaveDocument(). 
У тіло кожного з методів додайте виведення на екран відповідних рядків: "Документ відкритий", "Редагування документа у версії Про", "Збереження документа у версії Про".
Створіть похідний клас ProDocumentWorker. Перевизначте відповідні методи, при перевизначенні методів виводьте наступні рядки: "Документ відредаговано", "Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт".
Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker. Перевизначте відповідний спосіб. При викликі даного методу необхідно виводити на екран "Документ збережений у новому форматі".
У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу pro і exp. 
Якщо користувач не вводить ключ, він може користуватися лише безкоштовною версією (створюється екземпляр базового класу), якщо користувач ввів номери ключа доступу pro і exp, то повинен створити екземпляр відповідної версії класу, наведений до базового - DocumentWorker.
 */
class DocumentWorker
{
 public virtual void OpenDocument()
    {
        Console.WriteLine("Документ відкритий");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Редагування документа у версії Про");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Збереження документа у версії Про");
    }
  
}
class ProDocumentWorker : DocumentWorker
{
    
    public override void EditDocument()
    {
        Console.WriteLine("Документ відредаговано");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
    }

}
class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        DocumentWorker free = new DocumentWorker();
        ProDocumentWorker pro = new ProDocumentWorker();
        ExpertDocumentWorker exp = new ExpertDocumentWorker();


        Console.WriteLine("Введіть номер ключа. Якщо такого немає нажміть Enter");
        string Key = Console.ReadLine();
        if (Key == "pro")
        {
            pro.OpenDocument();
            pro.EditDocument();
            pro.SaveDocument();

        }
        else if (Key == "exp")
        {
            exp.OpenDocument();
            exp.EditDocument();
            exp.SaveDocument();
        }
        else 
        {
            
            free.OpenDocument();
            free.EditDocument();
            free.SaveDocument();
        }
    }
}
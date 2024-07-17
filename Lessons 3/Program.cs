
/*
 Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
Потрібно: Створити клас, який представляє навчальний клас ClassRoom. Створіть клас учень Pupil. У тілі класу створіть методи void Study(), void Read(), void Write(), void Relax(). 
Створіть 3 похідні класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil і перевизначте кожен із методів, залежно від успішності учня. 
Конструктор класу ClassRoom приймає аргументи типу Pupil, клас має складатися із 4 учнів. Передбачте можливість, що користувач може передати 2 або 3 аргументи. 
Виведіть інформацію про те, як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати. 
 */
class ClassRoom
{
    Random rand = new Random(); // В пам'яті свторюю місце для класу Random , посилання на місце в пам'яті зберігаю в полі rand
    Pupil[] pupils = new Pupil[4]; // В пам'яті створюю масив розміром 4 елементи, посилання на місце в пам'яті зберігаю в полі pupils

    public ClassRoom(Pupil p0, Pupil p1) // створюю користувацький конструктор який приймає 2 значення. Клас виконує функцію заповнення масиву значень
    {
        pupils[0] = p0; // інціалізую значення масиву 0-вого елементу значенням який приймає конструктор
        pupils[1] = p1;  // інціалізую значення масиву 1-го елементу значенням який приймає конструктор
        pupils[2] = GeneratePupil(); // ініціаліазую значення масиву 3-го елементу значенням яки віддає значення в класі GeneratePupil
        pupils[3] = GeneratePupil(); // ініціаліазую значення масиву 3-го елементу значенням яки віддає значення в клас GeneratePupil
    }
   /* 
    public ClassRoom(Pupil p0, Pupil p1, Pupil p2) // ініціалізую користувацький конструктор який приймає 3 значення. Клас виконує функцію заповнення масиву значень
    {
        pupils[0] = p0;
        pupils[1] = p1;
        pupils[2] = p2;
        pupils[3] = GeneratePupil();
    }
   */
    private Pupil GeneratePupil() // створюю приватний метод який повертає один із класів ExcelentPupil, GoodPupil, BadPupil
    {
        int r = rand.Next(1, 4); // викликаю метод який випадково передає змінній r значення від 1 до 4
        switch (r) // створення конструкці switch в параметр якої передаємо значення змінної r
        {
            case 1: //
                {
                    return new ExcelentPupil(); // якщо значення 1 констуркції повертає клас ExcelentPupil
                }

            case 2:
                {
                    return new GoodPupil(); //
                }
            case 3:
                {
                    return new BadPupil(); //
                }
            default:
                {
                    return new BadPupil(); //
                }
        }     
    }
  
    public void Study()
    {
        for (int i = 0; i < pupils.Length; i++) // 
        {
            pupils[i].Study(); // Виклик методу Study для об'єкта i
        }
    }
    public void Write()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            pupils[i].Write();
        }
    }
    public void Read()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            pupils[i].Read();
        }
    }
    public void Relax()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            pupils[i].Relax();
        }
    }
}
    internal class Program
    {
        private static void Main(string[] args)
        {
        Pupil p1 = new BadPupil(); // 
        Pupil p2 = new ExcelentPupil();

        ClassRoom group = new ClassRoom(p1, p2); 

        group.Study();
        Console.WriteLine(new string('-', 50));
        group.Read();
        Console.WriteLine(new string('-', 50));
        group.Write();
        Console.WriteLine(new string('-', 50));
        group.Relax();
        

        Console.ReadKey();
    }
    }
/*
 * 
 * 
 * 
 * 
 */
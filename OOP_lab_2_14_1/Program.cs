using System;

namespace OOP_lab_2_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть номер квартири");
            int n = int.Parse(Console.ReadLine());
            switch ((n - 1) / 5 + 1)
            {
                case 1:
                    Console.WriteLine("Квартира знаходиться на першому поверсi.");
                    break;
                case 2:
                    Console.WriteLine("Квартира знаходиться на другому поверсi.");
                    break;
                case 3:
                    Console.WriteLine("Квартира знаходиться на третьому поверсi.");
                    break;
                case 4:
                    Console.WriteLine("Квартира знаходиться на четвертому поверсi.");
                    break;
                case 5:
                    Console.WriteLine("Квартира знаходиться на п'ятому поверсi.");
                    break;
                case 6:
                    Console.WriteLine("Квартира знаходиться на шостому поверсi.");
                    break;
                case 7:
                    Console.WriteLine("Квартира знаходиться на сьомому поверсi.");
                    break;
                case 8:
                    Console.WriteLine("Квартира знаходиться на восьмому поверсi.");
                    break;
                case 9:
                    Console.WriteLine("Квартира знаходиться на дев'ятому поверсi.");
                    break;
            }

        }
    }
}

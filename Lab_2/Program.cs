using System;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Самойлов Алексей ИУ5-34Б";
            Rectangle rect = new Rectangle(9, 5.2);
            Square square = new Square(11.1);
            Circle circle = new Circle(7);

            rect.Print();
            square.Print();
            circle.Print();

            Console.ReadKey();

        }
    }
}
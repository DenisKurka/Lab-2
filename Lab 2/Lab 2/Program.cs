using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address p = new Address();

            p.index = 02221;
            p.country = "Ukraine";
            p.city = "Kiev";
            p.street = "Lobachewskogo";
            p.house = "23";
            p.apartment = "711";

            p.Display();

            Rectangle s = new Rectangle(1.00, 1.00);
            Console.WriteLine("");
            s.AreaCalculator(1.00, 1.00, 1.00);
            Console.WriteLine("");
            s.PerimeterCalculator(1.00, 1.00, 1.00);

            Book n_book = new Book();
            Console.WriteLine("");
            n_book.whole_book();

            User n_user = new User();
            Console.WriteLine("");
            n_user.worksheet();

            Console.WriteLine("Which exchage you want to choice");
            Converter n_converter = new Converter(1.00, 1.00, 1.00);
            Console.ReadLine();
        }
    }
}

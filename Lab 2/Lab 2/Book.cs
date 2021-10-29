using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{
    class Book
    {
        public void whole_book()
        {
            Title title = new Title(); 
            title.Show(title.Name); 
            Author author = new Author();
            author.Show(author.Writer);
            Content content = new Content();
            content.Show(content.Сontents);
        }
    }

    class Title
    {
        public string Name { get; set; }
        public void Show(string name)
        {
            Name = name;
            Console.ForegroundColor = ConsoleColor.Blue;
            name = "Лабиринт костей";
            Console.WriteLine(name);
        }

    }

    class Author
    {
        public string Writer { get; set; }
        public void Show(string author)
        {
            Writer = author;
            Console.ForegroundColor = ConsoleColor.Red;
            author = "Рик Риордан";
            Console.WriteLine(author);
        }
    }

    class Content
    {
        public string Сontents { get; set; }
        public void Show(string сontent)
        {
            Сontents = сontent;
            Console.ForegroundColor = ConsoleColor.Green;
            сontent = "Незадолго до смерти глава могущественного клана Грейс Кэхилл меняет свое завещание." +
            " Теперь ее наследники встают перед выбором - либо получить 1 миллион долларов," +
            " либо пуститься в состязание и отыскать 39 ключей. Следуя оставленным знакам, " +
            "главные герои - 14-летняя Эми и 11-летний Дэн отправляются в парижские катакомбы, " +
            "где им предстоит найти первый ключ.";
            Console.WriteLine(сontent);
        }
    }
}

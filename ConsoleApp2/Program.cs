using System;

namespace ConsoleApp2
{
    class Book
    {
        public Title title { get; set; }
        public Author author { get; set; }
        public Content content { get; set; }

        public Book(string titleId, string authorId, string contentId)
        {
            title = new Title();
            author = new Author();
            content = new Content();
            title.title = titleId;
            author.author = authorId;
            content.content = contentId;

        }
        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
            
        }
    }
    class Title
    {
        public string title = "";
        public void Show()
        {
            Console.Write("Название: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title);
            Console.ResetColor();
        }
    }
    class Author
    {
        public string author = "";
        public void Show()
        {
            Console.Write("Автор: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(author);
            Console.ResetColor();
        }
    }
    class Content
    {
        public string content = "";
        public void Show()
        {
            Console.Write("контент: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("C# 4.0: полное руководство", "Герберт Шилдт", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis quis.\n");
            book.Show();

            Book book1 = new Book("НИ СЫ", "Джен Синсеро", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis quis.\n");
            book1.Show();

            Book book2 = new Book("Записки Сумасшедшего", "Лу Синь", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis quis.\n");
            book2.Show();

        }
    }
}

using Library;
using System;

namespace Topic_8_Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Super book", "123456");

            

            Console.WriteLine(book.Name);
            Console.WriteLine(book.Id);
        }
    }
}

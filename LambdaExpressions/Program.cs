using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public class BookRepo
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Title = "title1", Price = 5},
                new Book() {Title = "title2", Price = 11},
                new Book() {Title = "title3", Price = 20},

            };
        }
    }
    class Program
    {
        private static int Square(int number)
        {
            return number * number;
        }
        private static void Main(string[] args)
        {
           //Exmaple1();
           Example2();
        }

        private static void Exmaple1()
        {
            var sum = Square(5);
            Console.WriteLine(sum);

            //Func<int, int> square = Square;
            Func<int, int> square = number => number * number;
            var lambdaSum = square(10);

            Console.WriteLine(lambdaSum);
        }

        private static void Example2()
        {
            var books = new BookRepo().GetBooks();
            // var cheapBooks = books.FindAll(IsCheaperThan)
            var cheapBooks = books.FindAll(book => book.Price < 10);

            foreach (Book book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        static bool IsCheaperThan(Book book)
        {
            return book.Price < 10;
        }
        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
              new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
              new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
              new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
              new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
              new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
              new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
              new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);
            Console.WriteLine("-----");

            Exercise2_7(books);
            Console.WriteLine("-----");

            Exercise2_8(books);
        }

        private static void Exercise2_1(List<Book> books) {
            //var date = books.Select(b => new { b.Price, b.Pages });

            var book = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
            if (book != null) {
                Console.WriteLine("{0} {1}", book.Price, book.Pages);
            }
            #region
            //var results = books.Where(s => s.Title == "ワンダフル・C#ライフ");
            //foreach (var book in results) {
            //    Console.WriteLine("{0} {1}",book.Price,book.Pages);
            //}
            #endregion
        }

        private static void Exercise2_2(List<Book> books) {
            var results = books.Count(s => s.Title.Contains("C#"));
            Console.WriteLine(results);
        }

        private static void Exercise2_3(List<Book> books) {
            var results = books.Where(s => s.Title.Contains("C#")).Average(s => s.Pages);
            Console.WriteLine(results);
        }

        private static void Exercise2_4(List<Book> books) {
            var book = books.FirstOrDefault(b => b.Price >= 4000);
            if (book != null) {
                Console.WriteLine(book.Title);
            }
            #region
            //var results = books.Find(s => s.Price >= 4000);
            //Console.WriteLine(results.Title);
            #endregion
        }

        private static void Exercise2_5(List<Book> books) {
            var results = books.Where(s => s.Price <= 4000).Max(s => s.Pages);
            Console.WriteLine(results);
        }

        private static void Exercise2_6(List<Book> books) {
            var results = books.Where(s => s.Pages >= 400).OrderByDescending(p => p.Price);
            foreach (var s in results) {
                Console.WriteLine(s.Title + " " + s.Price);
            }
        }

        private static void Exercise2_7(List<Book> books) {
            var results = books.Where(s => s.Title.Contains("C#") && s.Pages <= 500);
            foreach (var s in results) {
                Console.WriteLine(s.Title);
            }
        }

        private static void Exercise2_8(List<Book> books) {
            foreach (var item in books.Select((b, i) => new { i, b.Title })) {
                Console.WriteLine((item.i + 1) + "冊目：" + item.Title);
            }
            #region
            //int index = 0; 
            //foreach (var s in books) {
            //    index++;
            //    Console.WriteLine("{0}冊目：{1}",index,s.Title);
            //}
            #endregion
        }

        class Book {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
    }
}

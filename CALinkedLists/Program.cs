using System;
using System.Collections.Generic;

namespace CALinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var lesson1 = new YTVideo { Id = "YTV1", Title = "Variables", Duration = new TimeSpan(00, 30, 00) };
            var lesson2 = new YTVideo { Id = "YTV2", Title = "Classes and Strcts", Duration = new TimeSpan(01, 20, 00) };
            var lesson3 = new YTVideo { Id = "YTV3", Title = "Expressions", Duration = new TimeSpan(00, 45, 00) };
            var lesson4 = new YTVideo { Id = "YTV4", Title = "Iterations", Duration = new TimeSpan(01, 10, 00) };
            var lesson5 = new YTVideo { Id = "YTV5", Title = "Generics", Duration = new TimeSpan(00, 20, 00) };
             
            //LinkedList<YTVideo> playlist = new LinkedList<YTVideo>(new YTVideo[] {
            //    lesson1,
            //    lesson2,
            //    lesson3,
            //    lesson4,
            //    lesson5
            //});

            LinkedList<YTVideo> playlist = new LinkedList<YTVideo>();
            playlist.AddFirst(lesson1);

            playlist.AddAfter(playlist.First, lesson2);
            var node3 = new LinkedListNode<YTVideo>(lesson3);
            playlist.AddAfter(playlist.First.Next, node3);
            playlist.AddBefore(playlist.Last, lesson4);

            playlist.AddLast(lesson5);
            Print("C# from zero to hero", playlist);
            Console.ReadKey();
        }

        static void Print(string title, LinkedList<YTVideo> playlist)
        {
            Console.WriteLine($"┌{title}");
            foreach (var item in playlist)
                Console.WriteLine(item);
            Console.WriteLine($"└");
            Console.WriteLine($"Total: {playlist.Count} item(s)");

        }
    }

    class YTVideo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; } // HH:MM:SS

        public override string ToString()
        {
            // C# Variables (00:30:00)
            //      https://www.youtube.com/watch?v=d6EpL33g9tg
            return $"├── {Title} ({Duration})\n│\thttps://www.youtube.com/watch?v={Id}";
        }
    }
}

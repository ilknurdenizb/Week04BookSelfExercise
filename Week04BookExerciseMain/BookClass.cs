using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04BookExerciseMain
{
    internal class BookClass
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }

        public BookClass()   //Non-parameterized constructor
        {
            Title = "Unkown Title";
            Author = "Unkown Author";
            YearPublished = 0;

        }

        public BookClass(string title, string author, int yearPublished) //Parameterized constructor
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
        }

        public void DisplayBookInfo()  //Method to display book information 
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Year Published: {YearPublished}");
        }
      
    }
}

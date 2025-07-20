using System;
using Week04BookExerciseMain;

class Program
{
    static void Main(string[] args)
        {
    BookClass book1 = new BookClass("1984", "George Orwell", 1949); // Using the parameterized constructor
    BookClass book2 = new BookClass("To Kill a Mockingbird", "Harper Lee", 1960);
    BookClass book3 = new BookClass(); // Using the default constructor

  book3.DisplayBookInfo(); // Display default book information
  book1.DisplayBookInfo(); // Display book1 information
  book2.DisplayBookInfo();
    }


}
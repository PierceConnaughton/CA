/*Author Pierce Connaughton 
 * 05/11/2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        /*1.	Create a new repo on Github and link it with your project in Visual Studio.  
         * Make sure the repo is public so that I can view it.  
         * If you are unsure how to do this just code the solution without linking to Github
         * 
         * 7.	Create 5 Book objects, you can use your own data or that in the screenshot.
         * 8.	Add these Book objects to a List called ReadingList
         * 9.	Write a method in Program.cs which displays the books in the reading list.
         *
         */
        static void Main(string[] args)
        {
            //entering dates for each book
            DateTime date1 = new DateTime(1895, 02, 12);
            DateTime date2 = new DateTime(1945, 03, 11);
            DateTime date3 = new DateTime(2011, 02, 23);
            DateTime date4 = new DateTime(2001, 05, 29);
            DateTime date5 = new DateTime(1495, 03, 31);

            //entering in data for all the objects
            Book book1 = new Book("IT", "Stephen King", date1, 200,Genre.Fiction );
            Book book2 = new Book("Carrie", "Stephen King", date2, 150, Genre.Fiction);
            Book book3 = new Book("Life Of Pi", "Jerry", date3, 232, Genre.Biography);
            Book book4 = new Book("Coding", "Michael Richards", date4, 123, Genre.Computing);
            Book book5 = new Book("Master Literature", "Arthur Phelp", date5, 89, Genre.Lierature);

            //putting objects in a list
            var ReadingList = new List<Book>();
            ReadingList.Add(book1);
            ReadingList.Add(book2);
            ReadingList.Add(book3);
            ReadingList.Add(book4);
            ReadingList.Add(book5);

            display(ReadingList);
            Console.WriteLine();

            //sorting list and displaying it in alphabetical order
            ReadingList.Sort();
            display(ReadingList);

            Console.WriteLine();
            Console.WriteLine("List with ages");
            displayAge(ReadingList);

        }
        #region Methods
        static void display(List<Book> bookList)
        {
            Console.WriteLine("{0,-25}{1,-25}{2,-25}{3,-25}{4,-25}","Title","Author","Published","Pages","Genre");
            //for each book object in the list of books write out its properies
            foreach (Book book in bookList)
            {
                Console.WriteLine(book.ToString());
            }
        }

        static void displayAge(List<Book> bookList)
        {

            DateTime zeroTime = new DateTime(1, 1, 1);

            Console.WriteLine("{0,-25}{1,-25}{2,-25}{3,-25}{4,-25}{5,-25}", "Title", "Author", "Published", "Pages", "Genre","Age");
            foreach (Book book in bookList)
            {
                //getting the date now and the date of book publish and finding the time span of it and finding how many years the book is old from the date now
                DateTime dateNow = DateTime.Now;
                DateTime b = book.Published;
                TimeSpan age = b - dateNow;
                int ages = (zeroTime - age).Year - 1;

                Console.WriteLine(book.ToString() + ages);
            }
        }
        #endregion Methods
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    /*3.	Add an enum called Genre which has the following options – Fiction/Biography/Computing/Literature
     */

        //our enum genre 
    enum Genre{
        Fiction,
        Biography,
        Computing,
        Lierature

    }

    /*4.	Add the following Properties to the Book class – Title[string], Author[string], Published[DateTime], Pages[int] and Genre[Genre].
     */

    class Book :IComparable
    {
        #region Properties
        //our properties
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public int Pages { get; set; }
        public Genre Genre { get; set; }
        #endregion Properties

        #region Constructors
        //constructor with nothing in it if you havent any idea of what your gonna put in the object
        public Book()
        {

        }

        //constructor with only 2 properties as arguments if you only know the author and title
        public Book(string title,string author)
        {
            Title = title;
            Author = author;
        }

        //constructor with all properties as arguments if you know all the info beforehand
        public Book(string title,string author,DateTime published,int pages,Genre genre)
        {

            Title = title;
            Author = author;
            Published = published;
            Pages = pages;
            Genre = genre;
        }
        #endregion Constructors

        #region Methods
        /*6.	Override the ToString() method to display all properties. 
         */

        // to string method too write all information about the object
        public override string ToString()
        {
            return string.Format("{0,-25}{1,-25}{2,-25}{3,-25}{4,-25}",  Title,  Author,  Published, Pages,  Genre);

        }

        //compares this object with the next object in the array
        public int CompareTo(object obj)
        {
            Book That = (Book)obj;
            //if the author in this object is same as the next one it will focus on the title to compare 
            if (this.Author == That.Author)
            {
                return this.Title.CompareTo(That.Title);
            }
            //if authors are not the same it will comapre the authors
            else
            {
                return this.Author.CompareTo(That.Author);
            }
            
            
                
                
        }
        #endregion Methods
    }
}

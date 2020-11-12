using System;

namespace Open_Lab_10._03
{
    class Book
    {
        string title;
        int pages;
        string category;
        string autor;
        int releaseDate;


        public int Release
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value > 2021 || value < 1450)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }

            }

        }
        public int Str
        {
            get
            {
                return pages;
            }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }

        }
        public string Kateg
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }

        }
        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }

        }
    }


        class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Autor = "Jozo";
            LOTR.Release = 2023;
            LOTR.Str = 12;
            LOTR.Kateg = "dráma";
            LOTR.Title = "Abeceda";

            Console.WriteLine("vydané " + LOTR.Release);
            Console.WriteLine("strán " + LOTR.Str);
            Console.WriteLine("Autor " + LOTR.Autor);
            Console.WriteLine("žáner " + LOTR.Kateg);
            Console.WriteLine("názov " + LOTR.Title);


        }
    }
}

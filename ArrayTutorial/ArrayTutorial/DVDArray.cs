using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTutorial
{
    class DVDThings
    {
        public static void Callfunc()
        {
            // The actual code for creating an Array to hold DVD's.
            DVD[] dvdCollection = new DVD[15];
            // Firstly, we need to actually create a DVD object for The Avengers.
            DVD avengersDVD = new DVD("The Avengers", 2012, "Joss Whedon");

            // Next, we'll put it into the 8th place of the Array. Remember, because we
            // started numbering from 0, the index we want is 7.
            dvdCollection[7] = avengersDVD;

            DVD incrediblesDVD = new DVD("The Incredibles", 2004, "Brad Bird");
            DVD findingDoryDVD = new DVD("Finding Dory", 2016, "Andrew Stanton");
            DVD lionKingDVD = new DVD("The Lion King", 2019, "Jon Favreau");

            // Put "The Incredibles" into the 4th place: index 3.
            dvdCollection[3] = incrediblesDVD;

            // Put "Finding Dory" into the 10th place: index 9.
            dvdCollection[9] = findingDoryDVD;

            // Put "The Lion King" into the 3rd place: index 2.
            dvdCollection[1] = lionKingDVD;

            DVD starWarsDVD = new DVD("Star Wars", 1977, "George Lucas");
            dvdCollection[3] = starWarsDVD;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
                if (dvdCollection[i] != null)
                    dvdCollection[i].ToString();
            }
            Console.WriteLine("length   :    " + dvdCollection.Length);
            Console.WriteLine("length   :    " + dvdCollection.LongLength);
        }

    }
  

    // A simple definition for a DVD.
    public class DVD
    {
        public String name;
        public int releaseYear;
        public String director;

        public DVD(String name, int releaseYear, String director)
        {
            this.name = name;
            this.releaseYear = releaseYear;
            this.director = director;
        }

        public override String ToString()
        {
           Console.WriteLine(
                this.name + ", directed by " + this.director + ", released in " + this.releaseYear);

            return String.Empty;

        }
    }
}

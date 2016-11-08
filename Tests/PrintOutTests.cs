using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WypozyczalniaDLL;

namespace Tests
{
    [TestClass]
    public class PrintOutTests
    {
        Movie leon, harry, kaczka;
        Rental rental1, rental2, rental3;

        [TestInitialize]
        public void Initial()
        {
            leon = new Movie("Leon Zawodowiec", 10);
            harry = new Movie("Harry Potter", (decimal)20.5);
            kaczka = new Movie("Kaczka Dziwaczka", (decimal)5.99);

            rental1 = new Rental(new DateTime(2016, 11, 8), new DateTime(2016, 11, 18));
            rental2 = new Rental(new DateTime(2016, 11, 10), new DateTime(2016, 11, 15));
            rental3 = new Rental(new DateTime(2016, 11, 10), new DateTime(2016, 11, 11));

            rental1.MoviesList.Add(leon);
            rental1.MoviesList.Add(kaczka);

            rental2.MoviesList.Add(leon);
            rental2.MoviesList.Add(harry);
            rental2.MoviesList.Add(kaczka);

            rental3.MoviesList.Add(kaczka);

            CategoryChild.Instance.AddMovie(kaczka);
            CategoryNormal.Instance.AddMovie(leon);
            CategoryNormal.Instance.AddMovie(harry);
            CategoryNew.Instance.AddMovie(harry);

            CategoryChild.Instance.PointsPerDay = 2;
            CategoryNormal.Instance.PointsPerDay = 5;
            CategoryNew.Instance.PointsPerDay = 10;
        }

        [TestMethod]
        public void PrintOut_Print()
        {
            IPrintOut printer = new PrintToString();

            string output = printer.PrintOut(rental1);
            string output2 = printer.PrintOut(rental3);
            string output3 = printer.PrintOut(rental2);
        }
    }
}

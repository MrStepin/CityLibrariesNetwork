using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLibrariesNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.Name = "Moscow";

            District southDistrict = new District();
            southDistrict.Name = "South";

            District northDistrict = new District();
            northDistrict.Name = "North";

            District westDistrict = new District();
            westDistrict.Name = "West";

            District eastDistrict = new District();
            eastDistrict.Name = "East";

            District centerDistrict = new District();
            centerDistrict.Name = "Center";

            Library lomonosovLibrary = new Library();
            lomonosovLibrary.Name = "Lomonosov";
            lomonosovLibrary.DistrictId = southDistrict.Id;

            Library leninLibrary = new Library();
            leninLibrary.Name = "Lenin";
            leninLibrary.DistrictId = southDistrict.Id;

            Library stalinLibrary = new Library();
            stalinLibrary.Name = "Stalin";
            stalinLibrary.DistrictId = westDistrict.Id;

            Library breznevLibrary = new Library();
            breznevLibrary.Name = "Breznev";
            breznevLibrary.DistrictId = eastDistrict.Id;

            Library romanovLibrary = new Library();
            romanovLibrary.Name = "Romanov";
            romanovLibrary.DistrictId = centerDistrict.Id;

            Visitor Visitor0 = new Visitor();
            Visitor0.Name = "0";
            Visitor Visitor1 = new Visitor();
            Visitor1.Name = "1";
            Visitor Visitor2 = new Visitor();
            Visitor2.Name = "2";
            Visitor Visitor3 = new Visitor();
            Visitor3.Name = "3";
            Visitor Visitor4 = new Visitor();
            Visitor4.Name = "4";
            Visitor Visitor5 = new Visitor();
            Visitor5.Name = "5";
            Visitor Visitor6 = new Visitor();
            Visitor6.Name = "6";
            Visitor Visitor7 = new Visitor();
            Visitor7.Name = "7";
            Visitor Visitor8 = new Visitor();
            Visitor8.Name = "8";
            Visitor Visitor9 = new Visitor();
            Visitor9.Name = "9";

            Book warAndPeace = new Book();
            warAndPeace.Author = "LevTolstoy";
            warAndPeace.Genre = "Novel";
            warAndPeace.Name = "War And Peace";

            Book masterAndMargarita = new Book();
            masterAndMargarita.Name = "Master and Margarita";
            masterAndMargarita.Genre = "Novel";
            masterAndMargarita.Author = "Michail Bulgakov";

            Book sherlokHolms = new Book();
            sherlokHolms.Name = "Sherlok Holms";
            sherlokHolms.Genre = "Detective";
            sherlokHolms.Author = "Conan Doyle";

            Book book1 = new Book();
            book1.Author = "1";
            book1.Genre = "1";
            book1.Name = "qwe";

            Book book2 = new Book();
            book2.Author = "2";
            book2.Genre = "2";
            book2.Name = "2";

            Book book3 = new Book();
            book3.Author = "3";
            book3.Genre = "3";
            book3.Name = "3";

            Book book4 = new Book();
            book4.Author = "4";
            book4.Genre = "4";
            book4.Name = "4";

            Book book5 = new Book();
            book5.Author = "1";
            book5.Genre = "1";
            book5.Name = "asd";

            Book book6 = new Book();
            book6.Author = "6";
            book6.Genre = "6";
            book6.Name = "6";

            Book book7 = new Book();
            book7.Author = "7";
            book7.Genre = "7";
            book7.Name = "7";

            Edition FirstWarAndPeace = new Edition();
            FirstWarAndPeace.QtyOfPages = 100;
            FirstWarAndPeace.BookId = warAndPeace.Id;
            FirstWarAndPeace.Binding = "Hard";

            Edition SecondWarAndPeace = new Edition();
            SecondWarAndPeace.QtyOfPages = 120;
            SecondWarAndPeace.BookId = warAndPeace.Id;
            SecondWarAndPeace.Binding = "Soft";

            Edition FirstMasterAndMargarita = new Edition();
            FirstMasterAndMargarita.QtyOfPages = 200;
            FirstMasterAndMargarita.BookId = masterAndMargarita.Id;
            FirstMasterAndMargarita.Binding = "Hard";

            Edition SecondMasterAndMargarita = new Edition();
            SecondMasterAndMargarita.QtyOfPages = 300;
            SecondMasterAndMargarita.BookId = masterAndMargarita.Id;
            SecondMasterAndMargarita.Binding = "Soft";

            Edition FirstSherlokHolms = new Edition();
            FirstSherlokHolms.QtyOfPages = 500;
            FirstSherlokHolms.BookId = sherlokHolms.Id;
            FirstSherlokHolms.Binding = "Hard";


            Edition SecondSherlokHolms = new Edition();
            SecondSherlokHolms.QtyOfPages = 600;
            SecondSherlokHolms.BookId = sherlokHolms.Id;
            SecondSherlokHolms.Binding = "Soft";

            BookCopy Copy1 = new BookCopy();

            Copy1.BookId = sherlokHolms.Id;
            Copy1.NumberOfEdition = SecondSherlokHolms.NumberOfEdition;
            Copy1.LibraryId = lomonosovLibrary.Id;

            BookCopy Copy2 = new BookCopy();

            Copy2.BookId = masterAndMargarita.Id;
            Copy2.NumberOfEdition = SecondMasterAndMargarita.NumberOfEdition;
            Copy2.LibraryId = leninLibrary.Id;

            Edition Edition3 = new Edition();
            Edition3.QtyOfPages = 100;
            Edition3.BookId = book5.Id;
            Edition3.Binding = "hard";

            BookCopy Copy3 = new BookCopy();

            Copy3.BookId = book5.Id;
            Copy3.NumberOfEdition = Edition3.NumberOfEdition;
            Copy3.LibraryId = stalinLibrary.Id;

            Edition Edition4 = new Edition();
            Edition4.QtyOfPages = 100;
            Edition4.BookId = book5.Id;
            Edition4.Binding = "hard";

            BookCopy Copy4 = new BookCopy();

            Copy4.BookId = book5.Id;
            Copy4.NumberOfEdition = Edition4.NumberOfEdition;
            Copy4.LibraryId = leninLibrary.Id;

            BookCopy Copy5 = new BookCopy();

            Copy5.BookId = warAndPeace.Id;
            Copy5.NumberOfEdition = FirstWarAndPeace.NumberOfEdition;
            Copy5.LibraryId = breznevLibrary.Id;

            BookCopy Copy6 = new BookCopy();

            Copy6.BookId = masterAndMargarita.Id;
            Copy6.NumberOfEdition = FirstMasterAndMargarita.NumberOfEdition;
            Copy6.LibraryId = romanovLibrary.Id;

            BookCopy Copy7 = new BookCopy();

            Copy7.BookId = sherlokHolms.Id;
            Copy7.NumberOfEdition = FirstSherlokHolms.NumberOfEdition;
            Copy7.LibraryId = lomonosovLibrary.Id;

            LibraryVisitor visitor0 = new LibraryVisitor();
            visitor0.VisitorId = Visitor0.Id;
            visitor0.LibraryId = lomonosovLibrary.Id;
            visitor0.BookCopyId = sherlokHolms.Id;
            visitor0.GetTime = "01.01.2020";
            visitor0.ReturnTime = "01.02.2020";

            LibraryVisitor visitor1 = new LibraryVisitor();
            visitor1.VisitorId = Visitor1.Id;
            visitor1.LibraryId = lomonosovLibrary.Id;
            visitor1.BookCopyId = Copy1.Id;
            visitor1.GetTime = "01.07.2010";
            visitor1.ReturnTime = "01.05.2020";

            LibraryVisitor visitor2 = new LibraryVisitor();
            visitor2.VisitorId = Visitor2.Id;
            visitor2.LibraryId = leninLibrary.Id;
            visitor2.BookCopyId = Copy2.Id;
            visitor2.GetTime = "01.01.2020";
            visitor2.ReturnTime = "";

            LibraryVisitor visitor3 = new LibraryVisitor();
            visitor3.VisitorId = Visitor3.Id;
            visitor3.LibraryId = lomonosovLibrary.Id;
            visitor3.BookCopyId = Copy7.Id;
            visitor3.GetTime = "01.4.2021";
            visitor3.ReturnTime = "01.10.2021";

            LibraryVisitor visitor4 = new LibraryVisitor();
            visitor4.VisitorId = Visitor4.Id;
            visitor4.LibraryId = leninLibrary.Id;
            visitor4.BookCopyId = Copy4.Id;
            visitor4.GetTime = "01.01.2019";
            visitor4.ReturnTime = "01.02.2021";

            LibraryVisitor visitor5 = new LibraryVisitor();
            visitor5.VisitorId = Visitor5.Id;
            visitor5.LibraryId = breznevLibrary.Id;
            visitor5.BookCopyId = Copy5.Id;
            visitor5.GetTime = "01.11.2020";
            visitor5.ReturnTime = "";

            LibraryVisitor visitor6 = new LibraryVisitor();
            visitor6.VisitorId = Visitor6.Id;
            visitor6.LibraryId = lomonosovLibrary.Id;
            visitor6.BookCopyId = Copy1.Id;
            visitor6.GetTime = "01.01.2016";
            visitor6.ReturnTime = "01.01.2020";

            LibraryVisitor visitor7 = new LibraryVisitor();
            visitor7.VisitorId = Visitor7.Id;
            visitor7.LibraryId = lomonosovLibrary.Id;
            visitor7.BookCopyId = Copy7.Id;
            visitor7.GetTime = "01.08.2018";
            visitor7.ReturnTime = "01.09.2020";

            LibraryVisitor visitor8 = new LibraryVisitor();
            visitor8.VisitorId = Visitor8.Id;
            visitor8.LibraryId = breznevLibrary.Id;
            visitor8.BookCopyId = Copy5.Id;
            visitor8.GetTime = "01.01.2000";
            visitor8.ReturnTime = "01.05.2020";

            LibraryVisitor visitor9 = new LibraryVisitor();
            visitor9.VisitorId = Visitor9.Id;
            visitor9.LibraryId = leninLibrary.Id;
            visitor9.BookCopyId = Copy2.Id;
            visitor9.GetTime = "01.03.2020";
            visitor9.ReturnTime = "";

            Library[] libraries = { lomonosovLibrary, leninLibrary, stalinLibrary, breznevLibrary, romanovLibrary };
            District[] districts = { southDistrict, eastDistrict, westDistrict, northDistrict, centerDistrict };
            Visitor[] visitors = { Visitor0, Visitor1, Visitor2, Visitor3, Visitor4, Visitor5, Visitor6, Visitor7, Visitor8, Visitor9 };
            Book[] books = { warAndPeace, sherlokHolms, masterAndMargarita, book1, book2, book3, book4, book5, book6, book7 };
            Edition[] editions = { FirstMasterAndMargarita, FirstSherlokHolms, FirstWarAndPeace, SecondMasterAndMargarita, SecondSherlokHolms, SecondWarAndPeace, Edition3, Edition4 };
            BookCopy[] booksCopy = { Copy1, Copy2, Copy3, Copy4, Copy5, Copy6, Copy7 };
            LibraryVisitor[] libraryVisitors = { visitor0, visitor1, visitor2, visitor3, visitor4, visitor5, visitor6, visitor7, visitor8, visitor9 };

            var namesOfLibraries = from l in libraries orderby l.Name select l.Name;
            foreach (var l in namesOfLibraries)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("\n");

            var query = from dist in districts
                        join lib in libraries
                        on dist.Id equals lib.DistrictId
                        group lib.Name by dist.Name;
            foreach (var d in query)
            {
                Console.WriteLine($"{d.Key} ({d.Count()})");
                foreach (string name in d)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("\n");

            var distWithLib = from dist in districts
                              join lib in libraries
                              on dist.Id equals lib.DistrictId
                              into libGroup where !libGroup.Any()
                              select dist;
            foreach (var d in distWithLib)
            {
                Console.WriteLine(d.Name);
            }
            Console.WriteLine("\n");

            var allVisitors = from v in visitors select v.Name;
            foreach (var v in visitors)
            {
                Console.WriteLine(v.Name);
            }
            Console.WriteLine("\n");

            var allVisitorsByLib = from vis in libraryVisitors
                                   join lib in libraries on vis.LibraryId equals lib.Id
                                   join v in visitors on vis.VisitorId equals v.Id
                                   group v.Name by lib.Name;
            foreach (var d in allVisitorsByLib)
            {
                Console.WriteLine($"{d.Key}");
                foreach (string name in d)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("\n");

            var allVisitorsByDist = from vis in libraryVisitors
                                    join lib in libraries on vis.LibraryId equals lib.Id
                                    join v in visitors on vis.VisitorId equals v.Id
                                    join dist in districts on lib.DistrictId equals dist.Id
                                    group v.Name by dist.Name;
            foreach (var d in allVisitorsByDist)
            {
                Console.WriteLine($"{d.Key}");
                foreach (string name in d)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("\n");

            var districtsByVisitors = from vis in libraryVisitors
                                      join lib in libraries on vis.LibraryId equals lib.Id
                                      join dist in districts on lib.DistrictId equals dist.Id
                                      join v in visitors on vis.VisitorId equals v.Id
                                      group v by dist into g
                                      orderby g.Count() descending
                                      select new
                                      {
                                          District = g.Key.Name,
                                          VisitorsCount = g.Count()
                                      };
            foreach (var d in districtsByVisitors)
            {
                Console.WriteLine($"District: {d.District}, VisitorsCount: {d.VisitorsCount}");
            }
            Console.WriteLine("\n");

            var qtyOfBookByGenre = from b in books
                                   group b.Id by b.Genre into g
                                   select new
                                   { bookQty = g.Count(),
                                       Name = g.Key
                                   };

            foreach (var booksQty in qtyOfBookByGenre)
            {
                Console.WriteLine($"{booksQty.Name} - {booksQty.bookQty}");
            }
            Console.WriteLine("\n");

            var qtyOfBookByGenreInLib = from b in books
                                        join bk in booksCopy on b.Id equals bk.BookId
                                        join lib in libraries on bk.LibraryId equals lib.Id
                                        group b.Genre by lib into g
                                        select new
                                        {
                                            BookQtyInGenreInLib = g.Count(),
                                            LibName = g.Key.Name
                                        };
            foreach (var booksQty in qtyOfBookByGenreInLib)
            {
                Console.WriteLine($"{booksQty.LibName} - {booksQty.BookQtyInGenreInLib}");
            }
            Console.WriteLine("\n");

            var qtyOfCopies = from b in books
                              join bk in booksCopy on b.Id equals bk.BookId
                              group bk.Id by b.Genre into g
                              select new
                              {
                                  bookQty = g.Count(),
                                  Name = g.Key
                              };
            foreach (var booksQty in qtyOfCopies)
            {
                Console.WriteLine($"{booksQty.Name} - {booksQty.bookQty}");
            }
            Console.WriteLine("\n");

            var mostPopularBook = from b in books
                                  join bk in booksCopy on b.Id equals bk.BookId
                                  join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                  group vl.BookCopyId by b into g
                                  orderby g.Count() descending
                                  select new
                                  {
                                      mostPopBook = g.Count(),
                                      BookName = g.Key.Name
                                  };
            Console.WriteLine($"{mostPopularBook.First().BookName} - {mostPopularBook.First().mostPopBook}");
            Console.WriteLine("\n");

            var mostPopularBookByLib = from b in books
                                       join bk in booksCopy on b.Id equals bk.BookId
                                       join lib in libraries on bk.LibraryId equals lib.Id
                                       group b by lib into g
                                       select new
                                       {
                                           libName = g.Key.Name,
                                           BookName = from b in g
                                                      join bk in booksCopy on b.Id equals bk.BookId
                                                      join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                                      group vl.BookCopyId by b into ng
                                                      orderby ng.Count() descending
                                                      select ng.Key.Name
                                       };
            foreach (var mpbBylib in mostPopularBookByLib)
            {
                Console.WriteLine($"{mpbBylib.libName} - {mpbBylib.BookName.First()}");
            }
            Console.WriteLine("\n");

            var mostPopularGenre = from b in books
                                   join bk in booksCopy on b.Id equals bk.BookId
                                   join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                   group vl.BookCopyId by b.Genre into g
                                   orderby g.Count() descending
                                   select new
                                   {
                                       mostPopGenre = g.Count(),
                                       GenreName = g.Key
                                   };
            Console.WriteLine($"{mostPopularGenre.First().GenreName} - {mostPopularGenre.First().mostPopGenre}");
            Console.WriteLine("\n");

            var mostPopularGenreByLib = from b in books
                                        join bk in booksCopy on b.Id equals bk.BookId
                                        join lib in libraries on bk.LibraryId equals lib.Id
                                        group b by lib into g
                                        select new
                                        {
                                            libName = g.Key.Name,
                                            GenreName = from b in g
                                                        join bk in booksCopy on b.Id equals bk.BookId
                                                        join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                                        group vl.BookCopyId by b.Genre into ng
                                                        orderby ng.Count() descending
                                                        select ng.Key
                                        };
            foreach (var mpbBylib in mostPopularGenreByLib)
            {
                Console.WriteLine($"{mpbBylib.libName} - {mpbBylib.GenreName.First()}");
            }
            Console.WriteLine("\n");

            var topBooks = from b in books
                           join bk in booksCopy on b.Id equals bk.BookId
                           join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                           group vl.BookCopyId by b.Genre into g
                           select new
                           {
                               mostPopGenre = g.Key,
                               BookNam = from v in g
                                         join bk in booksCopy on v equals bk.Id
                                         join b in books on bk.BookId equals b.Id
                                         group v by b into ng
                                         orderby ng.Count() descending
                                         select ng.Key.Name
                           };
            foreach (var mostPopGenre in topBooks)
            {
                Console.WriteLine($"Genre - {mostPopGenre.mostPopGenre}");
                foreach (var book in mostPopGenre.BookNam)
                {
                    Console.WriteLine(book);
                }

            }
            Console.WriteLine("\n");

            //By months

            var mostPopularBookByMonth = from b in books
                                         join bk in booksCopy on b.Id equals bk.BookId
                                         join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                         group vl.BookCopyId by b into g
                                         orderby g.Count() descending
                                         select new
                                         {
                                             mostPopBook = from vl in g
                                                           join bk in booksCopy on vl equals bk.Id
                                                           join b in books on bk.BookId equals b.Id
                                                           join vil in libraryVisitors on bk.Id equals vil.BookCopyId
                                                           group b by vil.GetTime into ng
                                                           orderby ng.Count() descending
                                                           select ng.Key,
                                             BookName = g.Key.Name
                                         };
            foreach (var mostPopBookByMonth in mostPopularBookByMonth)
            {
                Console.WriteLine($"{mostPopBookByMonth.BookName}");
                Console.WriteLine(mostPopBookByMonth.mostPopBook.First());

            }
            Console.WriteLine("\n");

            var mostPopularBookByLibByMonth = from b in books
                                              join bk in booksCopy on b.Id equals bk.BookId
                                              join lib in libraries on bk.LibraryId equals lib.Id
                                              group b by lib into g
                                              select new
                                              {
                                                  libName = g.Key.Name,
                                                  BookName = from b in g
                                                             join bk in booksCopy on b.Id equals bk.BookId
                                                             join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                                             group vl.BookCopyId by b into ng
                                                             orderby ng.Count() descending
                                                             select new
                                                             {
                                                                 NameOfBook = ng.Key.Name,
                                                                 Month = from vl in ng
                                                                         join bk in booksCopy on vl equals bk.Id
                                                                         join lib in libraries on bk.LibraryId equals lib.Id
                                                                         join vil in libraryVisitors on bk.Id equals vil.BookCopyId
                                                                         group lib by vil.GetTime into newg
                                                                         select newg.Key
                                                             }
                                              };
            foreach (var mpbBylibByMonth in mostPopularBookByLibByMonth)
            {
                Console.WriteLine($"{mpbBylibByMonth.libName}");
                foreach (var name in mpbBylibByMonth.BookName)
                {
                    Console.WriteLine($"{name.NameOfBook} - {name.Month.First()}");
                }
            }
            Console.WriteLine("\n");

            var mostPopularGenreByMonth = from b in books
                                          join bk in booksCopy on b.Id equals bk.BookId
                                          join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                          group vl.BookCopyId by b.Genre into g
                                          orderby g.Count() descending
                                          select new
                                          {
                                              mostPopGenre = from vl in g
                                                             join bk in booksCopy on vl equals bk.Id
                                                             join b in books on bk.BookId equals b.Id
                                                             join vil in libraryVisitors on bk.Id equals vil.BookCopyId
                                                             group b.Genre by vil.GetTime into ng
                                                             select ng.Key,
                                              GenreName = g.Key
                                          };
            Console.WriteLine($"{mostPopularGenreByMonth.First().GenreName} - {mostPopularGenreByMonth.First().mostPopGenre.First()}");
            Console.WriteLine("\n");

            var mostPopularGenreByLibByMonth = from b in books
                                               join bk in booksCopy on b.Id equals bk.BookId
                                               join lib in libraries on bk.LibraryId equals lib.Id
                                               group b by lib into g
                                               select new
                                               {
                                                   libName = g.Key.Name,
                                                   GenreName = from b in g
                                                               join bk in booksCopy on b.Id equals bk.BookId
                                                               join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                                               group vl.BookCopyId by b.Genre into ng
                                                               orderby ng.Count() descending
                                                               select new
                                                               {
                                                                   NameOfGenre = ng.Key,
                                                                   Month = from vl in ng
                                                                           join bk in booksCopy on vl equals bk.Id
                                                                           join lib in libraries on bk.LibraryId equals lib.Id
                                                                           join vil in libraryVisitors on bk.Id equals vil.BookCopyId
                                                                           group lib by vil.GetTime into newg
                                                                           select newg.Key
                                                               }
                                               };
            foreach (var mpbBylib in mostPopularGenreByLibByMonth)
            {
                Console.WriteLine($"{mpbBylib.libName}");
                foreach (var month in mpbBylib.GenreName)
                {
                    Console.WriteLine($"{month.NameOfGenre} - {month.Month.First()}");
                }
            }
            Console.WriteLine("\n");

            var topBooksByMonth = from b in books
                                  join bk in booksCopy on b.Id equals bk.BookId
                                  join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                  group vl.BookCopyId by b.Genre into g
                                  select new
                                  {
                                      mostPopGenre = g.Key,
                                      BookNam = from v in g
                                                join bk in booksCopy on v equals bk.Id
                                                join b in books on bk.BookId equals b.Id
                                                group v by b into ng
                                                orderby ng.Count() descending
                                                select new
                                                {
                                                    BookName = ng.Key.Name,
                                                    Month = from vl in ng
                                                            join bk in booksCopy on vl equals bk.Id
                                                            join vil in libraryVisitors on bk.Id equals vil.BookCopyId
                                                            join b in books on bk.BookId equals b.Id
                                                            group b.Genre by vil.GetTime into newg
                                                            select newg.Key
                                                }
                                  };
            foreach (var mostPop in topBooksByMonth)
            {
                Console.WriteLine($"{mostPop.mostPopGenre}");
                foreach (var book in mostPop.BookNam)
                {
                    Console.WriteLine($"{book.BookName} - {book.Month.First()}");
                }

            }
            Console.WriteLine("\n");

            //by year

            var mostPopularBookByYear = from b in books
                                        join bk in booksCopy on b.Id equals bk.BookId
                                        join vil in libraryVisitors on bk.Id equals vil.BookCopyId
                                        let year = vil.GetTime.Split('.')
                                        group b by year.Last() into newg
                                        orderby newg.Count() descending
                                        select new
                                        {
                                            Year = newg.Key,
                                            MostPopBookByYear = from b in newg
                                                                join bk in booksCopy on b.Id equals bk.BookId
                                                                join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                                                group vl.BookCopyId by b into g
                                                                orderby g.Count() descending
                                                                select new
                                                                {
                                                                    mostPopBook = g.Count(),
                                                                    BookName = g.Key.Name
                                                                }
                                        };

            foreach (var mostPopBook in mostPopularBookByYear)
            {
                Console.WriteLine($"{mostPopBook.Year}");
                Console.WriteLine($" {mostPopBook.MostPopBookByYear.First().BookName } ");

            }
            Console.WriteLine("\n");

            var mostPopularBookByLibByYear = from b in books
                                             join bk in booksCopy on b.Id equals bk.BookId
                                             join lib in libraries on bk.LibraryId equals lib.Id
                                             group b by lib into g
                                             select new
                                             {
                                                 libName = g.Key.Name,
                                                 BookYear = from b in g
                                                            join bk in booksCopy on b.Id equals bk.BookId
                                                            join vil in libraryVisitors on bk.Id equals vil.BookCopyId
                                                            let year = vil.GetTime.Split('.')
                                                            group b by year.Last() into newg
                                                            orderby newg.Count() descending
                                                            select new
                                                            {
                                                                Year = newg.Key,
                                                                MostPopBookByYear = from b in newg
                                                                                    join bk in booksCopy on b.Id equals bk.BookId
                                                                                    join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                                                                    group vl.BookCopyId by b into ng
                                                                                    orderby ng.Count() descending
                                                                                    select ng.Key.Name
                                                            }
                                             };
            foreach (var mpbBylibByYear in mostPopularBookByLibByYear)
            {
                Console.WriteLine($"{mpbBylibByYear.libName}");
                foreach (var name in mpbBylibByYear.BookYear)
                {
                    Console.WriteLine($"{name.Year} - {name.MostPopBookByYear.First()}");
                }
            }
            Console.WriteLine("\n");

            var mostPopularGenreByYear = from b in books
                                         join bk in booksCopy on b.Id equals bk.BookId
                                         join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                         group vl.BookCopyId by b.Genre into g
                                         orderby g.Count() descending
                                         select new
                                         {
                                             GenreName = g.Key,
                                             BookYear = from bk in g
                                                        join vil in libraryVisitors on bk equals vil.BookCopyId
                                                        join bookCopy in booksCopy on bk equals bookCopy.Id
                                                        join b in books on bookCopy.BookId equals b.Id
                                                        let year = vil.GetTime.Split('.')
                                                        group b.Genre by year.Last() into newg
                                                        orderby newg.Count() descending
                                                        select new
                                                        {
                                                            Year = newg.Key,
                                                            MostPopBookByYear = from b in newg
                                                                                join book in books on b equals book.Genre
                                                                                join bk in booksCopy on book.Id equals bk.BookId
                                                                                join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                                                                group vl.BookCopyId by book into ng
                                                                                orderby ng.Count() descending
                                                                                select ng.Key.Name

                                                        }
                                         }; 

            Console.WriteLine($"{mostPopularGenreByYear.First().GenreName}");
            foreach(var year in mostPopularGenreByYear.First().BookYear)
            {
                Console.WriteLine($"{year.Year} - {year.MostPopBookByYear.First()}");
            }
            Console.WriteLine("\n");

            var mostPopularGenreByLibByYear = from b in books
                                               join bk in booksCopy on b.Id equals bk.BookId
                                               join lib in libraries on bk.LibraryId equals lib.Id
                                               group b by lib into g
                                               select new
                                               {
                                                   libName = g.Key.Name,
                                                   Genre = from b in g
                                         join bk in booksCopy on b.Id equals bk.BookId
                                         join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                         group vl.BookCopyId by b.Genre into ngroup
                                         orderby ngroup.Count() descending
                                         select new
                                         {
                                             GenreName = ngroup.Key,
                                             BookYear = from bk in ngroup
                                                        join vil in libraryVisitors on bk equals vil.BookCopyId
                                                        join bookCopy in booksCopy on bk equals bookCopy.Id
                                                        join b in books on bookCopy.BookId equals b.Id
                                                        let year = vil.GetTime.Split('.')
                                                        group b.Genre by year.Last() into newg
                                                        orderby newg.Count() descending
                                                        select new
                                                        {
                                                            Year = newg.Key,
                                                            MostPopBookByYear = from b in newg
                                                                                join book in books on b equals book.Genre
                                                                                join bk in booksCopy on book.Id equals bk.BookId
                                                                                join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                                                                group vl.BookCopyId by book into ng
                                                                                orderby ng.Count() descending
                                                                                select ng.Key.Name

                                                        }
                                         }
                                         }; 

            foreach (var mpbBylib in mostPopularGenreByLibByYear)
            {
                Console.WriteLine($"{mpbBylib.libName}");
                foreach (var genre in mpbBylib.Genre)
                {
                    Console.WriteLine($"{genre.GenreName}");
                    foreach(var year in genre.BookYear)
                    {
                        Console.WriteLine($"{year.Year} - {year.MostPopBookByYear.First()}");
                    }
                }
            }
            Console.WriteLine("\n");

            var topBooksByYear = from b in books
                                  join bk in booksCopy on b.Id equals bk.BookId
                                  join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                  group vl.BookCopyId by b.Genre into g
                                  select new
                                  {
                                      mostPopGenre = g.Key,
                                      Genre = from b in g
                                                        join bk in booksCopy on b equals bk.Id
                                                        join book in books on bk.BookId equals book.Id
                                                        group b by book.Genre into ngroup
                                                        orderby ngroup.Count() descending
                                                        select new
                                                        {
                                                            GenreName = ngroup.Key,
                                                            BookYear = from bk in ngroup
                                                                       join vil in libraryVisitors on bk equals vil.BookCopyId
                                                                       join bookCopy in booksCopy on bk equals bookCopy.Id
                                                                       join b in books on bookCopy.BookId equals b.Id
                                                                       let year = vil.GetTime.Split('.')
                                                                       group b.Genre by year.Last() into newg
                                                                       orderby newg.Count() descending
                                                                       select new
                                                                       {
                                                                           Year = newg.Key,
                                                                           MostPopBookByYear = from b in newg
                                                                                               join book in books on b equals book.Genre
                                                                                               join bk in booksCopy on book.Id equals bk.BookId
                                                                                               join vl in libraryVisitors on bk.Id equals vl.BookCopyId
                                                                                               group vl.BookCopyId by book into ng
                                                                                               orderby ng.Count() descending
                                                                                               select ng.Key.Name

                                                                       }
                                                        }
                                  };
            foreach (var mostPop in topBooksByYear)
            {
                foreach (var genre in mostPop.Genre)
                {
                    Console.WriteLine($"{genre.GenreName}");
                    foreach(var year in genre.BookYear)
                    {
                        Console.WriteLine($"{year.Year}");
                        foreach(var book in year.MostPopBookByYear)
                        {
                            Console.WriteLine($"{book}");
                        }
                    }
                }

            }
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}

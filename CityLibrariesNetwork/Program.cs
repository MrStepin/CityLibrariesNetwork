﻿using System;
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
            Visitor Visitor1 = new Visitor();
            Visitor Visitor2 = new Visitor();
            Visitor Visitor3 = new Visitor();
            Visitor Visitor4 = new Visitor();
            Visitor Visitor5 = new Visitor();
            Visitor Visitor6 = new Visitor();
            Visitor Visitor7 = new Visitor();
            Visitor Visitor8 = new Visitor();
            Visitor Visitor9 = new Visitor();

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
            book1.Name = "1";

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
            book5.Name = "1";

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

            BookCopy Copy2 = new BookCopy();

            Copy2.BookId = masterAndMargarita.Id;
            Copy2.NumberOfEdition = SecondMasterAndMargarita.NumberOfEdition;

            Edition Edition3 = new Edition();
            Edition3.QtyOfPages = 100;
            Edition3.BookId = book5.Id;
            Edition3.Binding = "hard";

            BookCopy Copy3 = new BookCopy();
            
            Copy3.BookId = book5.Id;
            Copy3.NumberOfEdition = Edition3.NumberOfEdition;

            Edition Edition4 = new Edition();
            Edition4.QtyOfPages = 100;
            Edition4.BookId = book5.Id;
            Edition4.Binding = "hard";

            BookCopy Copy4 = new BookCopy();
            
            Copy4.BookId = book5.Id;
            Copy4.NumberOfEdition = Edition4.NumberOfEdition;

            BookCopy Copy5 = new BookCopy();
           
            Copy5.BookId = warAndPeace.Id;
            Copy5.NumberOfEdition = FirstWarAndPeace.NumberOfEdition;

            BookCopy Copy6 = new BookCopy();
            
            Copy6.BookId = masterAndMargarita.Id;
            Copy6.NumberOfEdition = FirstMasterAndMargarita.NumberOfEdition;

            BookCopy Copy7 = new BookCopy();
           
            Copy7.BookId = sherlokHolms.Id;
            Copy7.NumberOfEdition = FirstSherlokHolms.NumberOfEdition;

            LibraryVisitor visitor0 = new LibraryVisitor();
            visitor0.VisitorId = Visitor0.Id;
            visitor0.LibraryId = lomonosovLibrary.Id;
            visitor0.BookCopyId = sherlokHolms.Id;
            visitor0.GetTime = 1;
            visitor0.ReturnTime = 2;

            LibraryVisitor visitor1 = new LibraryVisitor();
            visitor1.VisitorId = Visitor1.Id;
            visitor1.LibraryId = lomonosovLibrary.Id;
            visitor1.BookCopyId = Copy1.Id;
            visitor1.GetTime = 1;
            visitor1.ReturnTime = 2;

            LibraryVisitor visitor2 = new LibraryVisitor();
            visitor2.VisitorId = Visitor2.Id;
            visitor2.LibraryId = leninLibrary.Id;
            visitor2.BookCopyId = Copy2.Id;
            visitor2.GetTime = 1;
            visitor2.ReturnTime = 2;

            LibraryVisitor visitor3 = new LibraryVisitor();
            visitor3.VisitorId = Visitor3.Id;
            visitor3.LibraryId = stalinLibrary.Id;
            visitor3.BookCopyId = Copy3.Id;
            visitor3.GetTime = 1;
            visitor3.ReturnTime = 2;

            LibraryVisitor visitor4 = new LibraryVisitor();
            visitor4.VisitorId = Visitor4.Id;
            visitor4.LibraryId = breznevLibrary.Id;
            visitor4.BookCopyId = Copy4.Id;
            visitor4.GetTime = 1;
            visitor4.ReturnTime = 2;

            LibraryVisitor visitor5 = new LibraryVisitor();
            visitor5.VisitorId = Visitor5.Id;
            visitor5.LibraryId = romanovLibrary.Id;
            visitor5.BookCopyId = Copy5.Id;
            visitor5.GetTime = 1;
            visitor5.ReturnTime = 2;

            LibraryVisitor visitor6 = new LibraryVisitor();
            visitor6.VisitorId = Visitor6.Id;
            visitor6.LibraryId = lomonosovLibrary.Id;
            visitor6.BookCopyId = Copy6.Id;
            visitor6.GetTime = 1;
            visitor6.ReturnTime = 2;

            LibraryVisitor visitor7 = new LibraryVisitor();
            visitor7.VisitorId = Visitor7.Id;
            visitor7.LibraryId = stalinLibrary.Id;
            visitor7.BookCopyId = Copy7.Id;
            visitor7.GetTime = 1;
            visitor7.ReturnTime = 2;

            LibraryVisitor visitor8 = new LibraryVisitor();
            visitor8.VisitorId = Visitor8.Id;
            visitor8.LibraryId = lomonosovLibrary.Id;
            visitor8.BookCopyId = Copy5.Id;
            visitor8.GetTime = 1;
            visitor8.ReturnTime = 2;

            LibraryVisitor visitor9 = new LibraryVisitor();
            visitor9.VisitorId = Visitor9.Id;
            visitor9.LibraryId = leninLibrary.Id;
            visitor9.BookCopyId = Copy3.Id;
            visitor9.GetTime = 1;
            visitor9.ReturnTime = 2;

            Library[] libraries = { lomonosovLibrary, leninLibrary, stalinLibrary, breznevLibrary, romanovLibrary };
            District[] districts = { southDistrict, eastDistrict, westDistrict, northDistrict, centerDistrict };
            Visitor[] visitors = { Visitor0, Visitor1, Visitor2, Visitor3, Visitor4, Visitor5, Visitor6, Visitor7, Visitor8, Visitor9 };
            Book[] books = {warAndPeace, sherlokHolms, masterAndMargarita, book1, book2, book3, book4, book5, book6, book7 };
            Edition[] editions = {FirstMasterAndMargarita, FirstSherlokHolms, FirstWarAndPeace, SecondMasterAndMargarita, SecondSherlokHolms, SecondWarAndPeace, Edition3, Edition4 };
            BookCopy[] booksCopy = {Copy1, Copy2, Copy3, Copy4, Copy5, Copy6, Copy7 };
            LibraryVisitor[] libraryVisitors = {visitor0, visitor1, visitor2, visitor3, visitor4, visitor5, visitor6, visitor7, visitor8, visitor9 };

            var namesOfLibraries = from l in libraries orderby l.Name select l.Name;
            foreach(var l in namesOfLibraries)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("\n");

            var south = from l in libraries where l.DistrictId == southDistrict.Id select l.Name ;
            Console.WriteLine($"{southDistrict.Name} ({south.Count()})");
            foreach (var l in south)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("\n");
            var west = from l in libraries where l.DistrictId == westDistrict.Id select l.Name;
            Console.WriteLine($"{westDistrict.Name} ({west.Count()})");
            foreach (var l in west)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("\n");
            var east = from l in libraries where l.DistrictId == eastDistrict.Id select l.Name;
            Console.WriteLine($"{eastDistrict.Name} ({east.Count()})");
            foreach (var l in east)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("\n");
            var north = from l in libraries where l.DistrictId == northDistrict.Id select l.Name;
            Console.WriteLine($"{northDistrict.Name} ({north.Count()})");
            foreach (var l in north)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("\n");
            var center = from l in libraries where l.DistrictId == centerDistrict.Id select l.Name;
            Console.WriteLine($"{centerDistrict.Name} ({center.Count()})");
            foreach (var l in center)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("\n");



            Console.ReadLine();
        }
    }
}

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
            lomonosovLibrary.DistrictId = southDistrict.DistrictId;

            Library leninLibrary = new Library();
            leninLibrary.Name = "Lenin";
            leninLibrary.DistrictId = southDistrict.DistrictId;

            Library stalinLibrary = new Library();
            stalinLibrary.Name = "Stalin";
            stalinLibrary.DistrictId = westDistrict.DistrictId;

            Library breznevLibrary = new Library();
            breznevLibrary.Name = "Breznev";
            breznevLibrary.DistrictId = eastDistrict.DistrictId;

            Library romanovLibrary = new Library();
            romanovLibrary.Name = "Romanov";
            romanovLibrary.DistrictId = centerDistrict.DistrictId;

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
            book1.Name = "2";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XamarinClasses.LINQ.Utils;

namespace XamarinClasses.LINQ
{
    class Program
    {
        private static List<int> _numbers;
        private static List<Citizen> _listOfCitizen;

        static void Main(string[] args)
        {                        
            InitNumberList();

            var numbers = _numbers.Where(x => x > 30).ToList();
            _numbers.Add(55);
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            var citizens = _listOfCitizen.AsParallel().Where(x => x.Age > 20).ToList();

            /*
            GetOverOrEqual30();
            FirstOne();
            TakeSecondPage();

            InitCitizenList();
            OldOf20();
            OrderByName();
             */ 

            Console.ReadKey();
        }

        static void InitNumberList()
        {
            _numbers = new List<int>();

            _numbers.Add(18);
            _numbers.Add(30);
            _numbers.Add(25);
            _numbers.Add(40);
            _numbers.Add(68);
            _numbers.Add(31);
        }

        static void GetOverOrEqual30()
        {                        
            List<int> over30 = _numbers.Where(pepito => pepito >= 30).ToList();

            foreach (int number in _numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void PlusList(int addValue)
        {            
            List<int> listPlus = _numbers.Select(x => x + addValue).ToList();

            foreach(int number in _numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void FirstOne()
        {                        
            Console.WriteLine(_numbers.FirstOrDefault(x => x == 25));
        }

        static void TakeSecondPage()
        {
            List<int> numbers2 = _numbers.Skip(5).ToList();

            foreach(int number in numbers2)
            {
                Console.WriteLine(number);
            }
        }

        static void InitCitizenList()
        {
            _listOfCitizen = new List<Citizen>();

            _listOfCitizen.Add(new Citizen() { Age = 30, Name = "Carlos" });
            _listOfCitizen.Add(new Citizen() { Age = 19, Name = "Maria" });
            _listOfCitizen.Add(new Citizen() { Age = 40, Name = "Sonia" });
            _listOfCitizen.Add(new Citizen() { Age = 29, Name = "Jose" });
        }

        static void OldOf20()
        {            
            List<Citizen> listOfCitizenOldOf20 = _listOfCitizen.Where(x => x.Age > 20).ToList();

            foreach(Citizen citizen in listOfCitizenOldOf20)
            {
                Console.WriteLine("Age {0} Name {1}", citizen.Age, citizen.Name);
            }
        }

        static void OrderByName()
        {            
            _listOfCitizen.Where(x => x.Age >= 30).OrderBy(x => x.Name).FirstOrDefault();

            List<Citizen> orderByName = _listOfCitizen.OrderBy(x => x.Name).ToList();

            foreach(Citizen citizen in orderByName)
            {
                Console.WriteLine("Age {0} Name {1}", citizen.Age, citizen.Name);
            }
        }

    }
}

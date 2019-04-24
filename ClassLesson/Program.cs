using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLesson
{
    class Group
    {
        private string Name;
    }
    class Students
    {
        private string Name;
        private string Surname;
        private string Group;

        public string _Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        //Change Name Type
        public string _Surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
        //Change Surname Type
        public string _Group
        {
            get
            {
                return Group;
            }
            set
            {
                Group = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Students std = new Students();
            Console.WriteLine("Adinizi Daxil Edin: ");
            std._Name = Console.ReadLine();

            Console.WriteLine("Soyadinizi Daxil Edin: ");
            std._Surname = Console.ReadLine();

            Console.WriteLine("Grupunuzu Daxil Edin");

            std._Group = Console.ReadLine();

            Console.WriteLine("Salam: {0} {1}. Sizin Qrupunuz: {2} ", std._Name , std._Surname , std._Group);

            //Group grp = new Group();
            //Console.WriteLine("Grup Adini Daxil Edin");
            //grp.Name = Console.ReadLine();
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factories
{
    internal class HighSchoolClassRoom : ClassroomFactory
    {
        public HighSchoolClassRoom(string className)
        {
            CreateClassRoom(className, "U Hla");
        }
        public override void CleaningClassroom()
        {
            Console.WriteLine("Highschool kids cleaning classroom");

        }

        public override void CreateClassRoom(string name, string teacher)
        {
            ClRoom hRoom = new ClRoom(name, teacher);
            GreetTeacher(hRoom.teacher);
            SingNationalAnthem();
            CleaningClassroom();
        }

        //public override void GreetTeacher(string name)
        //{
        //    Console.WriteLine("Greeting teacher:" + name);
        //}

        public override void ReadingComprehension()
        {
            Console.WriteLine("Highschool kids reading comprehension");
        }

       

        public override void SingNationalAnthem()
        {
            Console.WriteLine("Singing national anthem: This is common to all classroom");
        }
    }
}

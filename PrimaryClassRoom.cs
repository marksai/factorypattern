using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factories
{
    internal class PrimaryClassRoom : ClassroomFactory
    {
        public PrimaryClassRoom(string className)
        {
            CreateClassRoom(className, "Daw Mya");
        }

        public override void CreateClassRoom(string name, string teacher)
        {
            ClRoom hRoom = new ClRoom(name, teacher);
            GreetTeacher(hRoom.teacher);
            ReciteTimesTable();
            ReadingComprehension();
        }

        public override void ReadingComprehension()
        {
            Console.WriteLine("Primary kids reading ABCD and Poems");
        }

        public override void ReciteTimesTable()
        {
            Console.WriteLine("Primary Kids reciting Times Table");
        }
    }
}

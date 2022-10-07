using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factories
{
    public abstract class Classroom
    {
        public abstract void GreetTeacher(string name);
        public abstract void SingNationalAnthem();
        public abstract void ReciteTimesTable();
        public abstract void ReadingComprehension();
        public abstract void CleaningClassroom();
        public abstract void CreateClassRoom(string name, string teacher);
    }

    public class ClassroomFactory:Classroom
    {
        public override void GreetTeacher(string name)
        {
            Console.WriteLine("Greeting teacher:" +name);
        }

        public override void SingNationalAnthem()
        {
            Console.WriteLine("Singing national anthem: This is common to all classroom");
        }

        public override void ReciteTimesTable()
        {
            throw new NotImplementedException();
        }

        public override void ReadingComprehension()
        {
            throw new NotImplementedException();
        }

        public override void CleaningClassroom()
        {
            throw new NotImplementedException();
        }

        public override void CreateClassRoom(string name,string teacher)
        {
            throw new NotImplementedException();
        }

    }

    public class ClRoom
    {
        public ClRoom(string name, string teacher)
        {
            this.name = name;
            this.teacher = teacher;
        }

        public string name { get; set; }
        public string teacher { get; set; }
    }
}

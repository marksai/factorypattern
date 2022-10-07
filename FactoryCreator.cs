using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factories
{
    public class FactoryCreator
    {
        public ClassroomFactory CreateFactory(string className)
        {
            switch(className)
            {
                case "1A": return new PrimaryClassRoom(className);
                case "2A": return new HighSchoolClassRoom(className);
                default: throw new ArgumentException("Invalid classroom");

            }
        }
    }
}

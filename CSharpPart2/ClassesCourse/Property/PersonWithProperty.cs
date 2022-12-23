using System;

namespace CSharpPart2
{
    public class PersonWithProperty
    {
        private DateTime _birthday;

        // Property name should be pascalCase
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
    }
}

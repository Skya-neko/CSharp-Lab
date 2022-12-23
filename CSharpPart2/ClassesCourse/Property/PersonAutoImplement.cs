using System;

namespace CSharpPart2
{
    public class PersonAutoImplement
    {
        //var person = new PersonAutoImplement();
        //person.Birthday = new DateTime(1982, 1, 1);
        //Console.WriteLine(person.Age);
        public DateTime Birthday { get; set;  }

        // You don't want Age settable, simply don't declare set method
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthday;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}

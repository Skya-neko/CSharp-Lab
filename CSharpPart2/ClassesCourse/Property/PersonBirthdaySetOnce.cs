using System;

namespace CSharpPart2
{
    public class PersonBirthdaySetOnce
    {
        // this is the same with we set the birthday field readonly

        //var person2 = new PersonBirthdaySetOnce(new DateTime(1982, 1, 1));
        ////// the sentence below can't work because the set method is private
        ////person2.Birthday = new DateTime(1982, 1, 1);  
        //Console.WriteLine(person2.Age);

        public PersonBirthdaySetOnce(DateTime birthday)
        {
            Birthday = birthday;
        }
        public DateTime Birthday { get; private set; }

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

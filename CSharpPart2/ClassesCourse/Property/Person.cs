using System;

namespace CSharpPart2
{
    public class Person
    {
        //var person = new Person();
        //person.SetBirthday(new DateTime(1982, 1, 1));
        //Console.WriteLine(person.GetBirthday());

        private DateTime _birthday;
        public void SetBirthday(DateTime birthday)
        {
            _birthday = birthday;
        }
        
        public DateTime GetBirthday() 
        {
            return _birthday;
        }
    }
}

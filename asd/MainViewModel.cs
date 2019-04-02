using System;
using System.Collections.ObjectModel;

namespace asd
{
    public class MainViewModel
    {
        public ObservableCollection<Person> People { get; set; }
     
        public MainViewModel()
        {

            People = new ObservableCollection<Person>
            {
                new Person
                {
                    Name = "Name1",
                    Surname = "Surname1",
                    Age = 50
                },
                new Person
                {
                    Name = "Name2",
                    Surname = "Surname2",
                    Age = 23
                },
                new Person
                {
                    Name = "Name3",
                    Surname = "Surname3",
                    Age = 44
                },
            };
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }


}

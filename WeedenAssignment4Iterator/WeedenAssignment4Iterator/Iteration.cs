using System;
using System.Collections;
using System.Collections.Generic;
namespace WeedenAssignment4Iterator
{
        public class Iteration : IEnumerable
        {
            // Private list
            private List<Person> Persons = new List<Person>();

            // Public methods
            public void AddPartTime(string name, int number)
            {
                Persons.Add(new Person { Name = name, Number = number, Type = Person.TypeEnum.PartTime });
            }

            public void AddFullTime(string name, int number)
            {
                Persons.Add(new Person { Name = name, Number = number, Type = Person.TypeEnum.FullTime });
            }

            public IEnumerator GetEnumerator()
            {
                foreach (Person thePerson in Persons)
                {
                    yield return thePerson.Name;
                }
            }

            // Public members to the list
            public IEnumerable FullTime
            {
                get { return PersonsForType(Person.TypeEnum.FullTime); }
            }

            public IEnumerable PartTime
            {
                get { return PersonsForType(Person.TypeEnum.PartTime); }
            }

            public IEnumerable EvenNumbers
            {
                get { return PersonsEvenNumbers(); }
            }

            // Private methods
            private IEnumerable PersonsForType(Person.TypeEnum type)
            {
                foreach (Person person in Persons)
                {
                    if (person.Type == type)
                    {
                        yield return person.Name;
                    }
                }
            }

            private IEnumerable PersonsEvenNumbers()
            {
                foreach (Person person in Persons)
                {
                    if (person.Number % 2 == 0)
                    {
                        yield return person.Name;
                    }
                }
            }
    }
    }
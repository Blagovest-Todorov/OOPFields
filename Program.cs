using System;

namespace _02.SimpleClassDefinition
{

    class Cat   
    {
       
        public string name;
    }

    internal class Person  //by default the class is internal
    {
        //field declaration ! 
        private string name;  //fields are called variavbles on niveu class, they keep date for the current class
        private int age; //this variable are for the current object -> for the current instance, 
        //private is access modifier, meaninig, fields are acessible only into this class ! 
        //by default fields are private ! 
        // the good code practice requires to write private  on each fiels despaite it is private by default
        //fields are membersdefined inside a lass, hold internalobject state, can be static or per instance
        //can be private /public/ protected
        public Cat myCat;

        public Person(string name, int age)    
        {
            this.name = name;
            this.age = age;
        }

        public string Name   
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    this.name = value;
                }
            }
        }

        public void Introduce() 
        {
            Console.WriteLine("Hello! , my name is {0} and i am  {1}-years-old.", this.name, this.age ); 
        }

        public void Walk()  
        {
            Console.WriteLine("{0} is walking !", this.Name);
        }

    }

    class LearningOOP
    {
        static void Main(string[] args)
        {
            Person[] people = 
            {
               new Person("Pesho", 21)
               {
                  myCat = new Cat()
                  {
                    name = "Kotangens"
                  }
               },
               new Person("Gosho", 14)
               { 
                   myCat = new Cat()
                   {
                      name = "Kotkata na Gosho"
                   }
               }
            };

            foreach (var person in people)
            {
                person.Introduce(); //we call the method introduce to every element->person of teh arrray people! 
                Console.WriteLine("My Cat name is {0}", person.myCat.name);
            }
        }
    }

}


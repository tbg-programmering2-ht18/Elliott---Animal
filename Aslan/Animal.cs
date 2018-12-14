using System;
using System.Collections.Generic;
using System.Text;

namespace Aslan
{
    class Animal
    {
        public string name { get; set; }
        public string sound { get; set; }
        public Boolean canFly { get; set; }

        public string Show()
        {
            if(canFly == true)
            {
                return ("Name: " + name + "Sound: " + sound + "can it fly: yes" );

            }
            else
            {
                return ("Name: " + name + "Sound: " + sound + "can it fly: No");
            }
        }
    }

    class Dog : Animal
    {
        public Dog(string Name)
        {
            name = Name;
            sound = "Woff";
            canFly = false;
        }

    }

    class Cat : Animal
    {
        public Cat(string Name)
        {
            name = Name;
            sound = "mooo";
            canFly = false;
        }

    }

    class Bird : Animal
    {
        public Bird(string Name)
        {
            name = Name;
            sound = "kvikkvik";
            canFly = true;
        }

    }

}

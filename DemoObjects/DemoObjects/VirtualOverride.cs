using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjects
{
    class Animal
    {
        public virtual void HelloVirtual()
        {
            Console.WriteLine("Call Animal class virtual method");
        }

        public TA As<TA>() where TA : class
        {
            var type = typeof(TA);
            var instance = Activator.CreateInstance(type);

            PropertyInfo[] properties = type.GetProperties();
            foreach (var property in properties)
            {
                property.SetValue(instance, property.GetValue(this, null), null);
            }

            return (TA)instance;
        }
    }


    class Dog : Animal
    {
        public override void HelloVirtual()
        {
            Console.WriteLine("Call Dog class override method this is virtual in Animal class");
        }

    }

    class Cat : Dog
    {
        public override void HelloVirtual()
        {
            Console.WriteLine("Call Cat class override method that is override from Dog class");
        }

    }
    class VirtualOverride
    {
        public static void Main(string[] args)
        {
            Animal objAnimal = new Animal();
            
            Dog objCat=objAnimal.As<Dog>();
            
            objCat.HelloVirtual();
            Console.ReadKey();
        }

      
    }
}

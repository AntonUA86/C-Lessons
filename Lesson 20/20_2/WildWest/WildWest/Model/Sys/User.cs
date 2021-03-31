using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WildWest.Model.SuperHero;

namespace WildWest.Model.Sys
{  
   [Serializable]
   public class User
    {
        
        public string Name { get; }
        public ISuperHero SuperHero;
        string newName;





        public User(string name,ISuperHero superHero)
        {
            this.Name = name;
            SuperHero = superHero;
        }
        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(name));
            }

            Name = name;
        }
        [OnSerializing]
        public void SayName(StreamingContext context)
        {
          newName =   this.Name + "Ky-Ky";
            Console.WriteLine($"{newName}");
        }
        [OnDeserialized]
        public void CheckNewName(StreamingContext context)
        {
                Console.WriteLine(newName);
        }


        public override string ToString()
        {
            return Name + " " + SuperHero;
        }
    }

}


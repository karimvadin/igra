using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Cat
    {
        public string name;
        public int age;
        public int health;
        public int strange;
        Random rnd = new Random();
        public Cat()
        {
        }
        public void talk()
        {
            Console.WriteLine("слыш ты мяу");
        }

        public void getHealth(int x)
        {
            health = health + x;
        }

        public void getDamage(int x)
        {
            health = health - x;
        }

        public int hit()
        {
            int popal = rnd.Next(1, 2);
            int damage = 0;
            if (popal == 1) {
                strange = rnd.Next(10, 15);
                damage = strange;
                return damage;
            }
            return damage;
        }
        public void getInfo()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Здоровье: " + health);
            if (health <= 0)
            {
                Console.WriteLine("Персонаж мертв.");
            }
            else
            {
                Console.WriteLine("Персонаж жив.");
            }
            Console.WriteLine(" ");
        }

    }
}



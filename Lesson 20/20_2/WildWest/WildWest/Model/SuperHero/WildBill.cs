using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildWest.Model.Location;
using WildWest.Model.Weapon;

namespace WildWest.Model.SuperHero
{
    [Serializable]
    public class WildBill : ISuperHero
    {
        public readonly string name = "Wild Bill";
        int level = 1;
        double health = 120;
        double exp = 0;


        Gun gun = new Gun();
        ListLocations locations = new ListLocations();

        public string Name { get => name; }
        public int Level { get => level; set => level = value; }
        public double Health { get => health; set => health = value; }
        public double Exp { get => exp; set => exp = value; }

        struct CurrentQuest
        {
            public static string name { get; set; }
        }

        public WildBill(int level, int health, int exp)
        {
            Level = level;
            Health = health;
            Exp = exp;
        }
        public WildBill()
        {

        }

        public string AttackWeapon()
        {
            return $"Выстрел: {gun.Name} урон: {gun.Shot()}";
        }

        public override string ToString()
        {
            return $"Имя: {Name} Уровинь: {Level}\n Здоровья: {Health} Опыт: {Exp} Оружие: {gun.Name}";
        }

        public string StartQuests(string nameQuest)
        {

            foreach (var loc in locations.GetAllLocations(nameQuest))
            {
                CurrentQuest.name = nameQuest;
                return loc.ToString();
            }
            return "Уровень не доступен";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIceTask
{
    class Program
    {
        class Hero
        {
            private int hp, damage, critical;
            private string name;
            Random r = new Random();

            public int Hp { get => hp; }
            public int Damage { get => damage; }
            public int Critical { get => critical; }
            public string Name { get => name; }

            
            public Hero(int hp, int damage, int critical, string name)
            {
                this.hp = hp;
                this.damage = damage;
                this.critical = critical;
                this.name = name;
            }

            private string elvenName(string name)
            {
                char[] characters = name.ToArray();
                Array.Sort(characters);
                return new string(characters);
            }

            private int randomiseHP()
            {
                return r.Next(100, 500);
            }

            private int randomiseDamage()
            {
                return r.Next(10, 50);
            }

            private int randomiseCrit()
            {
                return r.Next(25, 100);
            }

            public string MyString()
            {
                return  "Hero Name: " + name + "\n" + "Hero HP: " + Convert.ToString(hp) + "\n" +
                "Hero Damage: " + Convert.ToString(damage) + "\n" + "Hero Critical Chance: " + Convert.ToString(critical);
            }

            private bool checkCrit()
            {
                int crit = r.Next(1, 101);

                if (crit >= 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        class Enemy
        {
            private int hp, damage, critical;
            private string name, type;
            Random r = new Random();

            public int Hp { get => hp;}
            public int Damage { get => damage;}
            public int Critical { get => critical;}
            public string Name { get => name;}
            public string Type { get => type;}

            public Enemy(int hp, int damage, int critical, string name, string type)
            {
                this.hp = hp;
                this.damage = damage;
                this.critical = critical;
                this.type = type;

                switch (rollEnemyType())
                {
                    case 1:
                        name = "Goblin";
                        break;
                    case 2:
                        name = "Dragon";
                        break;
                    case 3:
                        name = "Ugandan Knuckles";
                        break;
                }
            }

            private int randomiseHP()
            {
                return r.Next(100, 500);
            }

            private int randomiseDamage()
            {
                return r.Next(10, 50);
            }

            private int randomiseCrit()
            {
                return r.Next(25, 100);
            }

            private int rollEnemyType()
            {
                return  r.Next(0, 3);

            }

            public string MyString()
            {
                return  "\n" + "Enemy Name: " + name + "\n" + "Enemy HP: " + Convert.ToString(hp) + "\n" +
                "Enemy Damage: " + Convert.ToString(damage) + "\n" + "Enemy Critical Chance: " + Convert.ToString(critical);
            }

            private bool checkCrit()
            {
                int crit = r.Next(1, 101);

                if (crit >= 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}

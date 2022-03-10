using System;

namespace Dungeon_Raider
{
    public abstract class Player
    {
        protected string character_name;
        protected string type;
        protected int health;
        protected int level;
        protected int experience;
        protected int strength;
        protected int shield;

        public abstract int attack();
        public abstract void take_damage(int damage);
        public abstract int defense(int damage);
        public abstract void levelUp();
        public abstract void gain_exp(int exp);
    }

    public abstract class Monster
    {
        protected string monster_name;
        protected int health;
        protected int exp;
        protected int strength;
        protected int shield;

        public abstract int attack();
        public abstract void take_damage(int damage);
        public abstract int die();
    }

    // Declare Players Classes
    public class Dovahkiin : Player
    {
        protected string type = "Dovahkiin";
        protected int health = 100;
        protected int level = 1;
        protected int experience = 0;
        protected int strength = 60;
        protected int shield = 50;

        public int Health
        {
            get { return health; }
        }

        public int Strength
        {
            get { return strength; }
        }

        public int Shield
        {
            get { return shield; }
        }

        public string Name
        {
            get { return character_name; }
            set { character_name = value; }
        }
        public int XP
        {
            get { return experience; }
        }
        public int Level
        {
            get { return level; }
        }

        public int Experience
        {
            get { return experience; }
        }

        public void print_status(int h)
        {
            Console.Write(h);
        }

        public void print_status(string n)
        {
            Console.Write(n);
        }

        public override int attack()
        {
            return (strength);
        }
        public override void take_damage(int damage)
        {
            int d = (damage - shield);
            if (d < 0)
            {
                d = 4;
            }

            health -= d;
        }
        public override int defense(int damage)
        {
            int res = damage - shield ;
            return res;
        }
        public override void levelUp()
        {
            level += 1;
            strength += 15;
            shield += 10;
            health = 100;
            Console.WriteLine("\nLevel: " + level + "\tExperience: " + experience
                   + "\tStrength: " + strength + "\tShield: " + shield + "\n");
        }
        public override void gain_exp(int exp)
        {
            experience += exp;
            Console.WriteLine("You gained "+exp+"xp,  Experience: "+experience);

            if (experience >= 400)
            {
                levelUp();
            }
            else if (experience >= 300 && experience < 360)
            {
                levelUp();
            }
            else if (experience >= 200 && experience < 260)
            {
                levelUp();
            }
            else if(experience >= 100 && experience < 160)
            {
                levelUp();
            }
        }
    }

    public class Askeladd : Player
    {
        protected string type = "Askeladd";
        protected int health = 100;
        protected int level = 1;
        protected int experience = 0;
        protected int strength = 50;
        protected int shield = 50;

        public int Health
        {
            get { return health; }
        }

        public int Strength
        {
            get { return strength; }
        }

        public int Shield
        {
            get { return shield; }
        }

        public string Name
        {
            get { return character_name; }
            set { character_name = value; }
        }
        public int XP
        {
            get { return experience; }
        }
        public int Level
        {
            get { return level; }
        }

        public int Experience
        {
            get { return experience; }
        }
        public void print_status(int h)
        {
            Console.Write(h);
        }

        public void print_status(string n)
        {
            Console.Write(n);
        }

        public override int attack()
        {
            return strength;
        }
        public override void take_damage(int damage)
        {
            int d = (damage - shield );
            if (d < 0)
            {
                d = 4;
            }

            health -= d;
        }
        public override int defense(int damage)
        {
            int res = damage - shield ;
            return res;
            
        }
        public override void levelUp()
        {
            level += 1;
            strength += 10;
            shield += 15;
            health = 100;
            Console.WriteLine("\nLevel: " + level + "\tExperience: " + experience
                   + "\tStrength: " + strength + "\tShield: " + shield + "\n");
        }
        public override void gain_exp(int exp)
        {
            experience += exp;
            Console.WriteLine("You gained " + exp + "xp,  Experience: " + experience);

            if (experience >= 400)
            {
                levelUp();
            }
            else if (experience >= 300 && experience < 360)
            {
                levelUp();
            }
            else if (experience >= 200 && experience < 260)
            {
                levelUp();
            }
            else if (experience >= 100 && experience < 160)
            {
                levelUp();
            }
        }
    }

    // Declare Monsters Classes
    public class Skeleton : Monster
    {
        protected string monster_name = "Skeleton";
        protected int health =150;
        protected int exp =50;
        protected int strength = 55;
        protected int shield = 15;

        public string Name
        {
            get { return monster_name; }
        }

        public int Health
        {
            get { return health; }
        }

        public override int attack()
        {
            return strength;
        }
        public override void take_damage(int damage)
        {
            health -= (damage - shield);
        }

        public override int die()
        {
                return exp;
        }
    }
    public class Gobline : Monster
    {
        protected string monster_name = "Gobline";
        protected int health = 180;
        protected int exp = 100;
        protected int strength = 60;
        protected int shield = 20;

        public string Name
        {
            get { return monster_name; }
        }

        public int Health
        {
            get { return health; }
        }

        public override int attack()
        {
            return strength;
        }
        public override void take_damage(int damage)
        {
            health -= (damage - shield);
        }
        public override int die()
        {
            return exp;
        }
    }
    public class Vampire : Monster
    {
        protected string monster_name = "Vampire";
        protected int health = 200;
        protected int exp = 150;
        protected int strength = 77;
        protected int shield = 30;

        public string Name
        {
            get { return monster_name; }
        }

        public int Health
        {
            get { return health; }
        }

        public override int attack()
        {
            return strength;
        }
        public override void take_damage(int damage)
        {
            health -= (damage - shield);
        }
        public override int die()
        {
            return exp;
        }
    }
    public class Boss : Vampire
    {
        protected string monster_name = "Master Vampire";
        protected int health = 230;
        protected int exp = 200;
        protected int strength = 82;
        protected int shield = 50;

        public string Name
        {
            get { return monster_name; }
        }

        public int Health
        {
            get { return health; }
        }

        public override int attack()
        {
            return strength;
        }
        public override void take_damage(int damage)
        {
            health -= (damage - shield);
        }
        public override int die()
        {
            return exp;
        }
    }
}
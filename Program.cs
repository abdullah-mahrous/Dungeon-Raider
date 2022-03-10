using System;
using System.Threading;
namespace Dungeon_Raider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Welcome Adventurer to Dungeon Raider tomp of heroes, beasts lair and myths' home...\n\n");
            Console.Write("Choose your character:\n1-");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Dovahkiin");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n2-");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Askeladd\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Your choice: ");
            int char_choice = int.Parse(Console.ReadKey().KeyChar.ToString());;
            Console.Write("\n\n");

            if (char_choice == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                // Set up user player
                Dovahkiin player = new Dovahkiin();
                Console.Write("You choose ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Dovahkiin\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter your name: ");
                player.Name = Console.ReadLine();
                Console.WriteLine("\nLevel: "+player.Level+ "\tExperience: "+player.Experience
                    + "\tStrength: "+player.Strength +"\tShield: "+player.Shield+"\n");
                Console.WriteLine("The game will start in....");

                for(int i = 3; i >= 1; i--)
                {
                    Thread.Sleep(700);
                    Console.WriteLine(i);
                }

                string story="\nYou were walking one day in your normal boring life\nThinking about how are you going to pay the rent of this month\n" +
                    "All of a sudden you fall over a long tunnel...\nYou found yourself in a very dark and scary room hearing loud deep voices behind you\n" +
                    "You felt like your heart is going to bounce out  of your chest and legs were shaking\n" +
                    "You felt a cold big hand touching you from behind so you turned quickly as you could\nBut you didn't find anything it was like your worst " +
                    "nightmare coming true...\n\n" ;
                story_teller(story, 40);

               story = "The smell of blood and cold dead bodies and the idea of never seeing your beautiful wife and your lovely children started to sink " +
                    "in your head...\n" +
                    "It felt hopeless that when you heard a loud dead voice comming from ahead of you and when you looked closely you saw the unimagenable..." +
                    "\nIt was a dead worrier skeleton holding in his hand and comming towards you...\n" +
                    "you pulled your sword out but you were too afraid to fight\n" +
                    "\nBut you had two choices...\n\nEither die in this hole by the skeleton \tor\t Fight for your life???\n\n\n";
                story_teller(story, 40);

                // Level 1
                Skeleton skeley = new Skeleton();
                // Fight playing
                while (player.Health > 0)
                {
                    if (!(skeley.Health > 0))
                    {
                        Console.WriteLine("You killed " + skeley.Name +"\n");
                        int exp = skeley.die();
                        player.gain_exp(exp);
                        
                        break;
                    }

                    Console.Write("Health: ");
                    player.print_status(player.Health);
                    Console.Write("\t\t" +skeley.Name+ " Health: "+skeley.Health+"\n");
                    Console.WriteLine(skeley.Name+" is attacking you!!\nwhat will you do ?\n1- Attack\t\t2- Defense");
char_choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine("\n");
                    if (char_choice==1)
                    {
                        skeley.take_damage(player.attack());
                        player.take_damage(skeley.attack());
                    }
                    else if (char_choice==2)
                    {
                        player.take_damage(player.defense(skeley.attack()));
                    }
                }
                if(player.Health <= 0)
                {
                    Console.WriteLine("You are Dead\nGame Over....");
                    Console.ReadKey();
                    return;
                }


                // Level 2
                //scene

                story = "\n\n\nyou walked tierd after your fight with the skeleton thinking about how is that creature even real...\n " +
                    "but you kept walking drived by the idea of getting out of this nightmare\n" +
                    "but in the middile of all this you felt some thing moving inside you when you killed that skeleton and swang that sword\n" +
                    "and before you knew it you found your self in front of an ugly who was very aggriseve\n" +
                    "you didnt belive in the past that the gobline was real....\n" +
                    "but they were real now and either he would remain in this dungeon or you\n\n\n";
                story_teller(story, 40);
                
                
                Gobline goby = new Gobline();
                // Fight playing
                while (player.Health > 0)
                {
                    if (!(goby.Health > 0))
                    {
                        Console.WriteLine("You killed " + goby.Name + "\n");
                        int exp = goby.die();
                        player.gain_exp(exp);
                        
                        break;
                    }

                    Console.WriteLine("Health: " + player.Health + "\t\t" + goby.Name + " Health: " + goby.Health + "\n");
                    Console.WriteLine(goby.Name + " is attacking you!!\nwhat will you do ?\n1- Attack\t\t2- Defense");
                    char_choice = int.Parse(Console.ReadKey().KeyChar.ToString());;
                    Console.WriteLine("\n");
                    if (char_choice == 1)
                    {
                        goby.take_damage(player.attack());
                        player.take_damage(goby.attack());
                    }
                    else if (char_choice == 2)
                    {
                        player.take_damage(player.defense(goby.attack()));
                    }
                }
                if (player.Health <= 0)
                {
                    Console.WriteLine("You are Dead\nGame Over....");
                    return;
                    Console.ReadKey();
                }


                // Level 3
                story = "after along fight with the gobline you managed to give him what he diserved\n" +
                    "but after the fight you were sure now you really liked it\n" +
                    "you were always good with sword and you always won the fights back then but killing these monster felt nothing like before\n" +
                    "it seemed like it was your thing....\n" +
                    "when you went further more into the dungeon you started realizing why it was so scary\n" +
                    "you saw bats every where and blood on stone tables\n" +
                    "and the next thing toy saw was a very fast man who tried to ripe your arm off\n" +
                    "you held your sword like nothing before and looked him in his red eyes..\n\n" +
                    "vampire : you went to the wronge hole mortal\n" +
                    "vampire : now you are going to be my dinner...\n\n\n";
                story_teller(story,40);


                Vampire vampy = new Vampire();
                // Fight playing
                while (player.Health > 0)
                {
                    if (!(vampy.Health > 0))
                    {
                        Console.WriteLine("You killed " + vampy.Name + "\n");
                        int exp = vampy.die();
                        player.gain_exp(exp);
                        
                        break;
                    }

                    Console.WriteLine("Health: " + player.Health + "\t\t" + vampy.Name + " Health: " + vampy.Health + "\n");
                    Console.WriteLine(vampy.Name + " is attacking you!!\nwhat will you do ?\n1- Attack\t\t2- Defense");
char_choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine("\n");
                    if (char_choice == 1)
                    {
                        vampy.take_damage(player.attack());
                        player.take_damage(vampy.attack());
                    }
                    else if (char_choice == 2)
                    {
                        player.take_damage(player.defense(vampy.attack()));
                    }
                }
                if (player.Health <= 0)
                {
                    Console.WriteLine("You are Dead\nGame Over....");
                    return;
                    Console.ReadKey();
                }


                // Level 4
                story = "you finally tooke that bastard head off\n" +
                    "but you reamembered all the roumers off people disapperance in this area and now you know why...\n" +
                    "you wanted to leave this place at once but you felt like it was your responsibility to end this shit hole for good\n" +
                    "it was a hard choise but before you could make mind a tall gray haired man walked into the room\n" +
                    "with an angry look on his face he tolld you...\n" +
                    "Master Vampire : so you killed my servants and even managed to kill my loyal guard mortal!!" +
                    "Master Vampire : you have done very well mortal...\n" +
                    "but the play time is over..... its time to die\n\n\n";
                story_teller(story,40);


                Boss drac = new Boss();
                // Fight playing
                while (player.Health > 0)
                {
                    if (!(drac.Health > 0))
                    {
                        Console.WriteLine("You killed " + drac.Name + "\n");
                        int exp = drac.die();
                        player.gain_exp(exp);
                        
                        break;
                    }

                    Console.WriteLine("Health: " + player.Health + "\t\t" + drac.Name + " Health: " + drac.Health + "\n");
                    Console.WriteLine(drac.Name + " is attacking you!!\nwhat will you do ?\n1- Attack\t\t2- Defense");
char_choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine("\n");
                    if (char_choice == 1)
                    {
                        drac.take_damage(player.attack());
                        player.take_damage(drac.attack());
                    }
                    else if (char_choice == 2)
                    {
                        player.take_damage(player.defense(drac.attack()));
                    }
                }
                if (player.Health <= 0)
                {
                    Console.WriteLine("You are Dead\nGame Over....");
                    return;
                    Console.ReadKey();
                }
                else
                {
                    story = "\n\n\nMaster Vampire : how could you mortal!!...\n" +
                        "Master Vampire : im the 300 years old and no one ever managed to do this to me before...\n" +
                        "who are you mortal ??!!\n" +
                        player.Name+" : im the new monster slayer...\n" +
                        "i gave that old bastard a goodbye blow with my sword and looked around to see a narow tannel that lead outside\n" +
                        "it was like heaven to smell the frash air again...\n" +
                        "i looked back at the dungeon telling my self that this nightmare has finally ended\n" +
                        "but acctualy it was just the begging.....\n\n\n";
                    story_teller(story,40);

                    Console.Write("Congratulations ");
                    player.print_status(player.Name);
                     Console.Write(" you survived the dungeon!");
                    Console.ReadKey();
                }
            }



            else if(char_choice == 2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                // Set up user player
                Askeladd player = new Askeladd();
                Console.Write("You choose ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Askeladd\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Enter your name: ");
                player.Name = Console.ReadLine();
                Console.WriteLine("\nLevel: " + player.Level + "\tExperience: " + player.Experience
                    + "\tStrength: " + player.Strength + "\tShield: " + player.Shield + "\n");
                Console.WriteLine("The game will start in....");

                for (int i = 3; i >= 1; i--)
                {
                    Thread.Sleep(700);
                    Console.WriteLine(i);
                }

                string story = "\nYou were walking one day in your normal boring life\nThinking about how are you going to pay the rent of this month\n" +
                    "All of a sudden you fall over a long tunnel...\nYou found yourself in a very dark and scary room hearing loud deep voices behind you\n" +
                    "You felt like your heart is going to bounce out  of your chest and legs were shaking\n" +
                    "You felt a cold big hand touching you from behind so you turned quickly as you could\nBut you didn't find anything it was like your worst " +
                    "nightmare coming true...\n\n";
                story_teller(story, 40);

                story = "The smell of blood and cold dead bodies and the idea of never seeing your beautiful wife and your lovely children started to sink " +
                     "in your head...\n" +
                     "It felt hopeless that when you heard a loud dead voice comming from ahead of you and when you looked closely you saw the unimagenable..." +
                     "\nIt was a dead worrier skeleton holding in his hand and comming towards you...\n" +
                     "you pulled your sword out but you were too afraid to fight\n" +
                     "\nBut you had two choices...\n\nEither die in this hole by the skeleton \tor\t Fight for your life???\n\n\n";
                story_teller(story, 40);

                // Level 1
                Skeleton skeley = new Skeleton();
                // Fight playing
                while (player.Health > 0)
                {
                    if (!(skeley.Health > 0))
                    {
                        Console.WriteLine("You killed " + skeley.Name + "\n");
                        int exp = skeley.die();
                        player.gain_exp(exp);
                        
                        break;
                    }

                    Console.WriteLine("Health: " + player.Health + "\t\t" + skeley.Name + " Health: " + skeley.Health + "\n");
                    Console.WriteLine(skeley.Name + " is attacking you!!\nwhat will you do ?\n1- Attack\t\t2- Defense");
char_choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine("\n");
                    if (char_choice == 1)
                    {
                        skeley.take_damage(player.attack());
                        player.take_damage(skeley.attack());
                    }
                    else if (char_choice == 2)
                    {
                        player.take_damage(player.defense(skeley.attack()));
                    }
                }
                if (player.Health <= 0)
                {
                    Console.WriteLine("You are Dead\nGame Over....");
                    return;
                    Console.ReadKey();
                }


                // Level 2

                story = "\n\n\nyou walked tierd after your fight with the skeleton thinking about how is that creature even real...\n" +
                    "but you kept walking drived by the idea of getting out of this nightmare\n" +
                    "but in the middile of all this you felt some thing moving inside you when you killed that skeleton and swang that sword\n" +
                    "and before you knew it you found your self in front of an ugly who was very aggriseve\n" +
                    "you didnt belive in the past that the gobline was real....\n" +
                    "but they were real now and either he would remain in this dungeon or you\n\n\n";
                story_teller(story, 40);

                Gobline goby = new Gobline();
                // Fight playing
                while (player.Health > 0)
                {
                    if (!(goby.Health > 0))
                    {
                        Console.WriteLine("You killed " + goby.Name + "\n");
                        int exp = goby.die();
                        player.gain_exp(exp);
                        
                        break;
                    }

                    Console.WriteLine("Health: " + player.Health + "\t\t" + goby.Name + " Health: " + goby.Health + "\n");
                    Console.WriteLine(goby.Name + " is attacking you!!\nwhat will you do ?\n1- Attack\t\t2- Defense");
char_choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine("\n");
                    if (char_choice == 1)
                    {
                        goby.take_damage(player.attack());
                        player.take_damage(goby.attack());
                    }
                    else if (char_choice == 2)
                    {
                        player.take_damage(player.defense(goby.attack()));
                    }
                }
                if (player.Health <= 0)
                {
                    Console.WriteLine("You are Dead\nGame Over....");
                    return;
                    Console.ReadKey();
                }


                // Level 3
                Vampire vampy = new Vampire();

                story = "after along fight with the gobline you managed to give him what he diserved\n" +
                    "but after the fight you were sure now you really liked it\n" +
                    "you were always good with sword and you always won the fights back then but killing these monster felt nothing like before\n" +
                    "it seemed like it was your thing....\n" +
                    "when you went further more into the dungeon you started realizing why it was so scary\n" +
                    "you saw bats every where and blood on stone tables\n" +
                    "and the next thing toy saw was a very fast man who tried to ripe your arm off\n" +
                    "you held your sword like nothing before and looked him in his red eyes..\n\n" +
                    "vampire : you went to the wronge hole mortal\n" +
                    "vampire : now you are going to be my dinner...\n\n\n";
                story_teller(story, 40);

                // Fight playing
                while (player.Health > 0)
                {
                    if (!(vampy.Health > 0))
                    {
                        Console.WriteLine("You killed " + vampy.Name + "\n");
                        int exp = vampy.die();
                        player.gain_exp(exp);
                        
                        break;
                    }

                    Console.WriteLine("Health: " + player.Health + "\t\t" + vampy.Name + " Health: " + vampy.Health + "\n");
                    Console.WriteLine(vampy.Name + " is attacking you!!\nwhat will you do ?\n1- Attack\t\t2- Defense");
char_choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine("\n");
                    if (char_choice == 1)
                    {
                        vampy.take_damage(player.attack());
                        player.take_damage(vampy.attack());
                    }
                    else if (char_choice == 2)
                    {
                        player.take_damage(player.defense(vampy.attack()));
                    }
                }
                if (player.Health <= 0)
                {
                    Console.WriteLine("You are Dead\nGame Over....");
                    return;
                    Console.ReadKey();
                }

                // Level 4
                Boss drac = new Boss();

                story = "you finally tooke that bastard head off\n" +
                    "but you reamembered all the roumers off people disapperance in this area and now you know why...\n" +
                    "you wanted to leave this place at once but you felt like it was your responsibility to end this shit hole for good\n" +
                    "it was a hard choise but before you could make mind a tall gray haired man walked into the room\n" +
                    "with an angry look on his face he tolld you...\n" +
                    "Master Vampire : so you killed my servants and even managed to kill my loyal guard mortal!!" +
                    "Master Vampire : you have done very well mortal...\n" +
                    "but the play time is over..... its time to die\n\n\n";
                story_teller(story, 40);

                // Fight playing
                while (player.Health > 0)
                {
                    if (!(drac.Health > 0))
                    {
                        Console.WriteLine("You killed " + drac.Name + "\n");
                        int exp = drac.die();
                        player.gain_exp(exp);
                        
                        break;
                    }

                    Console.WriteLine("Health: " + player.Health + "\t\t" + drac.Name + " Health: " + drac.Health + "\n");
                    Console.WriteLine(drac.Name + " is attacking you!!\nwhat will you do ?\n1- Attack\t\t2- Defense");
char_choice = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine("\n");
                    if (char_choice == 1)
                    {
                        drac.take_damage(player.attack());
                        player.take_damage(drac.attack());
                    }
                    else if (char_choice == 2)
                    {
                        player.take_damage(player.defense(drac.attack()));
                    }
                }
                if (player.Health <= 0)
                {
                    Console.WriteLine("You are Dead\nGame Over....");
                    return;
                    Console.ReadKey();
                }
                else
                {
                    story = "Master Vampire : how could you mortal!!...\n" +
                        "Master Vampire : im the 300 years old and no one ever managed to do this to me before...\n" +
                        "who are you mortal ??!!\n" +
                        player.Name + " : im the new monster slayer...\n" +
                        "i gave that old bastard a goodbye blow with my sword and looked around to see a narow tannel that lead outside\n" +
                        "it was like heaven to smell the frash air again...\n" +
                        "i looked back at the dungeon telling my self that this nightmare has finally ended\n" +
                        "but acctualy it was just the begging.....";
                    story_teller(story, 40);
                    Console.WriteLine("Congratulations " + player.Name + " you survived the dungeon!");
                    Console.ReadKey();
                }
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tInvalid choice!\n\tTerminating..");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
           
        }
        public static void story_teller(string story, int time)
        {
            for (var i = 0; i < story.Length; i++)
            {
                Thread.Sleep(time);
                Console.Write(story[i]);
            }
        }
    }

}

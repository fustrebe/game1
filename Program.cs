using System;

namespace Projekat1
{
    class Program
    {
        static void Main(string[] args)
        {
            Army Red = new Army("Red" , 10);
            Army Blue = new Army("Blue", 10);
            Red.setName();
            Blue.setName();
            while(Red.isArmyAlive() == true && Blue.isArmyAlive() == true)
            {
                //RED HITTING
                Warrior a = Red.getFirstWarriorNotHitted();
                if (a != null)
                {
                    Warrior b = Blue.getFirstWarriorNotHitten();
                    if (b != null)
                    {
                        if(a.isAlive() == true && b.isAlive() == true)
                        {
                            a.hit(b);
                            Console.WriteLine(b.name + "\nHealth: " + b.health);
                            
                        }
                        if (b.isAlive() == false)
                        {
                            Console.WriteLine("Warrior is dead!");
                        }
                        if(a.isAlive() == true && b.isAlive() == false)
                        {
                            Warrior c = Blue.getFirstWarriorNotHitten();
                            if (c != null)
                            {
                                a.hit(c);
                                Console.WriteLine(c.name + "\nHealth: " + c.health);
                            }
                            else
                            {
                                Blue.resetFlag();
                            }
                        }
                        if(a.isAlive() == false && b.isAlive() == true)
                        {
                            Warrior d = Red.getFirstWarriorNotHitted();
                            if (d != null)
                            {
                                d.hit(b);
                                Console.WriteLine(b.name + "\nHealth: " + b.health);
                            }
                            else
                            {
                                Red.resetFlag();
                            }
                        }
                        if (b.isAlive() == false)
                        {
                            Console.WriteLine("Warrior is dead!");
                        }
                    }
                    else
                    {
                        Blue.resetFlag();
                    }
                }
                else
                {
                    Red.resetFlag();
                }
                //BLUE HITTING
                Warrior e = Blue.getFirstWarriorNotHitted();
                if(e != null)
                {
                    Warrior f = Red.getFirstWarriorNotHitten();
                    if(f != null)
                    {
                        if(e.isAlive( ) == true && f.isAlive() == true)
                        {
                            e.hit(f);
                            Console.WriteLine(f.name + "\nHealth: " + f.health);
                        }
                        if (f.isAlive() == false)
                        {
                            Console.WriteLine("Warrior is dead!");
                        }
                        if(e.isAlive() == true && f.isAlive() == false)
                        {
                            Warrior g = Red.getFirstWarriorNotHitten();
                            if (g != null)
                            {
                                e.hit(g);
                                Console.WriteLine(g.name + "\nHealth: " + g.health);

                                if (g.isAlive() == false)
                                {
                                    Console.WriteLine("Warrior is dead!");
                                }
                            }
                            else
                            {
                                Red.resetFlag();
                            }
                        }
                        if(e.isAlive() == false&& f.isAlive() == true)
                        {
                            Warrior h = Blue.getFirstWarriorNotHitted();
                            if (h != null)
                            {
                                h.hit(f);
                                Console.WriteLine(f.name + "\nHealth: " + f.health);
                                if (f.isAlive() == false)
                                {
                                    Console.WriteLine("Warrior is dead!");
                                }
                            }
                            else
                            {
                                Blue.resetFlag();
                            }
                        }
                    }
                    else
                    {
                        Red.resetFlag();
                    }
                }
                else
                {
                    Blue.resetFlag();
                }
                
            }
            if(Red.isArmyAlive() == true && Blue.isArmyAlive() == false)
            {
                Console.WriteLine("Red Army Won!");
            }
            else if(Red.isArmyAlive() == false && Blue.isArmyAlive() == true)
            {
                Console.WriteLine("Blue Army Won!");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat1
{
    public class Army
    {
        public string name;
        public Warrior[] arr;

        public Army(string name, int numOfWarriors)
        {
            this.name = name;

            arr = new Warrior[numOfWarriors];
            for (int i = 0; i < numOfWarriors; i++)
            {
                arr[i] = new Warrior();
            }


        }
        public void setName()
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                string number = i.ToString();
                arr[i].setName(name + "Army Warrior: " + number);
            }
        }
        public Warrior getFirstWarriorNotHitted()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].isAlive() == true)
                {
                    if (arr[i].hitted == false)
                    {
                        return arr[i];
                    }
                }
            }
            return null;
        }
        public Warrior getFirstWarriorNotHitten()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].isAlive() == true)
                {
                    if (arr[i].hitten == false)
                    {
                        return arr[i];
                    }
                }
            }
            return null;
        }
        public void resetFlag()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].resetWarrior();
            }
        }
        public bool isArmyAlive()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].health > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public Warrior getFirstWarriorAlive()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].isAlive() == true)
                {
                    return arr[i];
                }
            }
            return null;
        }


    }
}

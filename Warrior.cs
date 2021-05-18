using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat1
{
    public class Warrior
    {

        public int health;
        public int damage;
        public bool hitten;
        public bool hitted;
        public string name;

        public Warrior()
        {
            this.health = 100;
            this.damage = 10;
            this.hitten = false;
            this.hitted = false;
            this.name = name;

        }
        public void takeDamage(int damage)
        {
            Random rd = new Random();
            int num = rd.Next(1, 51);
            if (this.health > 0)
            {
                this.health = this.health - (damage - (damage * num) / 100);
                this.hitten = true;
            }
        }
        public void hit(Warrior warrior)
        {
            Random rd = new Random();
            int rand_num = rd.Next(1, 11);
            int rand_num1 = rd.Next(1, 51);
            if (rand_num == 2)
            {
                this.health = this.health - (damage + (damage * rand_num1) / 100);
                this.hitted = true;
            }
            else
            {
                warrior.takeDamage(this.damage);
                this.hitted = true;
            }
        }
        public bool isAlive()
        {
            if (this.health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void resetWarrior()
        {
            if (this.hitten == true)
            {
                this.hitten = false;
            }
            if (this.hitted == true)
            {
                this.hitted = false;
            }
        }
    }
}

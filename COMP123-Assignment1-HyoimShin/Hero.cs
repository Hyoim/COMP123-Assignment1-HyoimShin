﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Hero
    {
        Random rnd = new Random();   // is used to generate random number

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++
        public string name;

        // PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++
        private int strength = 0;
        private int speed = 0;
        private int health = 0;

        // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(string name)
        {
            this.name = name;
            generateAblities(rnd);
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++

        //calls the hitAttempt method that determines sucess or failure of attack
        public void fight()
        {
            bool hitResult;      // success or failure for attack
            hitResult = hitAttempt(rnd);

            if (hitResult == true)
            {
                Console.WriteLine("---------------> Attack succeeded");
                hitDamage(rnd);
            }
            else
            {
                Console.WriteLine("---------------> Attack failed");
                Console.WriteLine();
            }
        }

        //displays hero's ability score
        public void show()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+{0, 19} {1, -13}+", "The ability of", this.name);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ {0, 17} {1, -13} +", "Strength:", this.strength);
            Console.WriteLine("+ {0, 17} {1, -13} +", "Speed:", this.speed);
            Console.WriteLine("+ {0, 17} {1, -13} +", "Health:", this.health);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++
        // generates the ability numbers for the strength, speed, health 
        private void generateAblities(Random rnd)
        {
            // Random class is used for making random hero's ability between 1 to 100 

            this.strength = rnd.Next(1, 101);
            this.speed = rnd.Next(1, 101);
            this.health = rnd.Next(1, 101);
        }

        //determines sucess or failure of hero's attack 
        private bool hitAttempt(Random rnd)
        {
            // Random class is used for determining success or failure for attack
            // Hero hits would succeed 20% of the time

            int hitAttempt = rnd.Next(1, 11);

            Console.WriteLine("---------------> Attempting attack");
            Console.WriteLine();

            if ((hitAttempt == 1) || (hitAttempt == 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void hitDamage(Random rnd)
        {
            // Random class is used for generating hit factor
            // the factor between 1 and 6 is used to calculate the hit damage

            int hitDamageFact = rnd.Next(1, 7);
            // Console.WriteLine(hitDamageFact);   // for testing a fact value

            // hit damage = hero's strength * hitDamageFact

            int damage = this.strength * hitDamageFact;
            Console.WriteLine("                 The target is attacked by {0}", damage);
            Console.WriteLine();
        }
    }
}
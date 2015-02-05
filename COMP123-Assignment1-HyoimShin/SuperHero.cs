﻿/********************************************************
 * Hyoim Shin (300802252)
 * February 5, 2015
 * Assignment2 : Implement SuperHero subclass of Hero
 * Revision History : 
 * - Crated constructor of SuperHero by using Hero Class
 * - Added generateRandomPowers method
 * ******************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SuperHero : Hero
    {
        Random rnd = new Random();

        // PRIVATE PROPERTIES +++++++++++++++++++++++++++++++++++++++++
        private string[] superPowerLists = {"Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control"};
        private bool[] checkDuplicateArr = new bool[6];    // is used to check whethere the value of superPowerList is already used or not(false->not use) 
        private string[] superPower = new string[3];       

        private int randomNum;

        // CONSTRUCTOR +++++++++++++++++++++++++++++++++++++++++
        public SuperHero(string name) : base(name)
        {
            generateRandomPowers();
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++
        public void showPowers()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(String.Format("Super power of {0}", this.name).PadLeft(42 - (14 - (this.name.Length / 2))));
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            
            for (int index = 0; index < this.superPower.Length; index++)
            {
                Console.WriteLine(String.Format("{0}", this.superPower[index]).PadLeft(42 - (21 - (this.superPower[index].Length / 2))));
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
 
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++
        // Generates three random superpowers
        private void generateRandomPowers()
        {
            initialCheckArray(checkDuplicateArr);
         
            int count = 0;
            while(count < superPower.Length)
            {
                randomNum = rnd.Next(6);

                // If the random number is not used, input the value of random number in superPowerLists to superPower array
                if (checkDuplicateArr[randomNum] == false)
                {
                    this.superPower[count] = superPowerLists[randomNum];
                    checkDuplicateArr[randomNum] = true;
                }
                // If the random number is already used, it generates other random number
                else if(checkDuplicateArr[randomNum] == true)
                {
                    while (checkDuplicateArr[randomNum] != false)
                    {
                        randomNum = rnd.Next(6);
                    }
                    this.superPower[count] = superPowerLists[randomNum];
                    checkDuplicateArr[randomNum] = true;
                }
                count++;
            }
        }

        // Initializes the value of checkValueArray as false
        private void initialCheckArray(bool[] checkValueArray)
        {
            int index = 0;
            while (index < checkValueArray.Length)
            {
                this.checkDuplicateArr[index] = false;
                index++;
            }
        }
    }
}

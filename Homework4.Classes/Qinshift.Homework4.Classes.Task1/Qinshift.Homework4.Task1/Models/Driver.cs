﻿
namespace Qinshift.Homework4.Task1.Models
{
    public class Driver
    {
        public Driver()
        {

        }

        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }

        public string Name { get; set; }
        public int Skill { get; set; }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Student
    {
        public string Name; //Имя//name
        public int Age; //Возраст//age
        public string[] KnowLanguage; //Массив языков//language
        public int YearZachisleniya; //Год зачисления//zet
        public Student()
        {
            Name = "Неизвестно";
            Age = 0;
            YearZachisleniya = 0;
            KnowLanguage = new string[10];



        }
        public string Getinfo()
        {
            string languages = "";
            foreach (var item in KnowLanguage)
            {
                languages = $"{languages} + {item}";

            }
            return $"Student - {Name}. Age - {Age}. Year income - {YearZachisleniya }";
        }
    } 

    }
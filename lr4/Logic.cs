using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4
{
    public class LogicWork
    {
        private String[] Mounts_ru = { " Января", " Февраля", " Марта", " Апреля", " Мая", " Июня", " Июля", " Августа", " Сентября", " Октября", " Ноября", " Декабря" };
        private String[] Mounts_en = { " January", " February", " March", " April", " May", " June", " July", " August", " September", " October", " November", " December" };
        private String[] Greatings_ru = { "Доброе утро, ", "Добрый день, ", "Добрый вечер, ", "Доброй ночи, " };
        private String[] Greatings_en = { "Good morning, ", "Good afternoon, ", "Good evening, ", "Good night, " };
        private static String[] Days_ru = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
        private static String[] Days_en = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        public String GetNameByDay(int lang, int number_day) 
        {
            String[] Days;
            switch (lang)
            {
                case 0: Days = Days_ru; break;
                case 1: Days = Days_en; break;
                default: throw new ArgumentException("lang");
            }
            if (number_day >= 1 && number_day <= 7 ) {
                return Days[number_day - 1];
            }
            else
            {
                throw new ArgumentException("Такого дня недели не существует");
            }
        }
        public double FindGipotenusa(int par1, int par2)
        {
            double res = Math.Sqrt(par1 * par1 + par2 * par2);
            return res;
        }
        public String DatePrint(int lang, String date) 
        {
            int day = int.Parse(date.Substring(0,2));
            int monthNumber = int.Parse(date.Substring(3,2));
            String res = Convert.ToString(day);
            switch (lang) 
            {
                case 0: return res + Mounts_ru[monthNumber - 1];
                case 1: return res + Mounts_en[monthNumber - 1];
                default: throw new ArgumentException();
            }
            
        }
        public String NameTime(int lang, String name, String time)
        {
            String[] Array;
            int hour = int.Parse (time.Substring (0,2));
            switch (lang)
            {
                case 0: Array = Greatings_ru; break; 
                case 1: Array = Greatings_en; break;
                default: throw new ArgumentException("Array");
            }
            
            if (hour >= 5 && hour <= 11) {
                return Array[0] + name;
            }
            else if (hour >= 12 && hour <= 16)
            {
                return Array[1] + name;
            }
            else if (hour >= 17 && hour <= 23)
            {
                return Array[2] + name;
            }
            else if (hour >= 0 && hour <= 4)
            {
                return Array[3] + name;
            }
            else
            {
                throw new ArgumentException("hour");
            }
        }
        public String GreatingBuild(int lang, String name, String time, String date, int dayNumber)
        {
            String res;
            switch (lang) 
            { 
                case 0: res = "Язык: Ru"; break;
                case 1: res = "Language: En"; break;
                default: throw new ArgumentException("lang"); 
            }
            res += " \n" + DatePrint(lang, date) + " " + GetNameByDay(lang, dayNumber) + " \n" + NameTime(lang, name, time);
            return res;
        }
    }
}

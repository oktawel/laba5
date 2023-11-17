using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace lr4
{
    [TestFixture]
    public class TestFixture1 
    {
        [Test]
        public void Test1()
        {
            LogicWork l = new LogicWork();
            int lang = 0;
            Assert.AreEqual("Пн", l.GetNameByDay(lang,1)); 
            Assert.AreEqual("Вт", l.GetNameByDay(lang, 2));
            Assert.AreEqual("Ср", l.GetNameByDay(lang, 3));
            Assert.AreEqual("Чт", l.GetNameByDay(lang, 4));
            Assert.AreEqual("Пт", l.GetNameByDay(lang, 5));
            Assert.AreEqual("Сб", l.GetNameByDay(lang, 6));
            Assert.AreEqual("Вс", l.GetNameByDay(lang, 7));
            Assert.Throws<ArgumentException>(() => l.GetNameByDay(lang, 8));
            lang = 1;
            Assert.AreEqual("Mon", l.GetNameByDay(lang, 1));
            Assert.AreEqual("Tue", l.GetNameByDay(lang, 2));
            Assert.AreEqual("Wed", l.GetNameByDay(lang, 3));
            Assert.AreEqual("Thu", l.GetNameByDay(lang, 4));
            Assert.AreEqual("Fri", l.GetNameByDay(lang, 5));
            Assert.AreEqual("Sat", l.GetNameByDay(lang, 6));
            Assert.AreEqual("Sun", l.GetNameByDay(lang, 7));
            Assert.Throws<ArgumentException>(() => l.GetNameByDay(lang, 8));
            lang = 2;
            Assert.Throws<ArgumentException>(() => l.GetNameByDay(lang, 1));
        }
        [Test]
        public void Test2()
        {
            LogicWork l = new LogicWork();
            int[] expectedValue = { 5, 233, 41, 97 };
            int[] kat1 = { 3, 105, 9, 65 };
            int[] kat2 = {4, 208, 40, 72};
            for (int i = 0; i < expectedValue.Length; i++) {
                Assert.AreEqual(expectedValue[i], l.FindGipotenusa(kat1[i], kat2[i]));
            }
        }
        [Test]
        public void Test3()
        {
            LogicWork l = new LogicWork();
            String name = "Dima";
            int lang = 0;
            Assert.AreEqual("Доброе утро, Dima", l.NameTime(lang, name, "07:19"));
            Assert.AreEqual("Добрый день, Dima", l.NameTime(lang, name, "14:32"));
            Assert.AreEqual("Добрый вечер, Dima", l.NameTime(lang, name, "20:54"));
            Assert.AreEqual("Доброй ночи, Dima", l.NameTime(lang, name, "00:12"));
            lang = 1;
            Assert.AreEqual("Good morning, Dima", l.NameTime(lang, name, "07:19"));
            Assert.AreEqual("Good afternoon, Dima", l.NameTime(lang, name, "14:32"));
            Assert.AreEqual("Good evening, Dima", l.NameTime(lang, name, "20:54"));
            Assert.AreEqual("Good night, Dima", l.NameTime(lang, name, "00:12"));
            lang = 2;
            Assert.Throws<ArgumentException>(() => l.NameTime(lang, name, "00:12"));
        }
        [Test]
        public void Test4()
        {
            LogicWork l = new LogicWork();
            int lang = 0;
            Assert.AreEqual("25 Января", l.DatePrint(lang, "25.01.2010"));
            Assert.AreEqual("18 Февраля", l.DatePrint(lang, "18.02.2023"));
            Assert.AreEqual("1 Марта", l.DatePrint(lang, "01.03.2016"));
            Assert.AreEqual("30 Апреля", l.DatePrint(lang, "30.04.2022"));
            Assert.AreEqual("17 Мая", l.DatePrint(lang, "17.05.2018"));
            Assert.AreEqual("24 Июня", l.DatePrint(lang, "24.06.2017"));
            Assert.AreEqual("7 Июля", l.DatePrint(lang, "07.07.2018"));
            Assert.AreEqual("12 Августа", l.DatePrint(lang, "12.08.2021"));
            Assert.AreEqual("21 Сентября", l.DatePrint(lang, "21.09.2016"));
            Assert.AreEqual("13 Октября", l.DatePrint(lang, "13.10.2022"));
            Assert.AreEqual("9 Ноября", l.DatePrint(lang, "09.11.2014"));
            Assert.AreEqual("31 Декабря", l.DatePrint(lang, "31.12.2020"));
            lang = 1;
            Assert.AreEqual("25 January", l.DatePrint(lang, "25.01.2010"));
            Assert.AreEqual("18 February", l.DatePrint(lang, "18.02.2023"));
            Assert.AreEqual("1 March", l.DatePrint(lang, "01.03.2016"));
            Assert.AreEqual("30 April", l.DatePrint(lang, "30.04.2022"));
            Assert.AreEqual("17 May", l.DatePrint(lang, "17.05.2018"));
            Assert.AreEqual("24 June", l.DatePrint(lang, "24.06.2017"));
            Assert.AreEqual("7 July", l.DatePrint(lang, "07.07.2018"));
            Assert.AreEqual("12 August", l.DatePrint(lang, "12.08.2021"));
            Assert.AreEqual("21 September", l.DatePrint(lang, "21.09.2016"));
            Assert.AreEqual("13 October", l.DatePrint(lang, "13.10.2022"));
            Assert.AreEqual("9 November", l.DatePrint(lang, "09.11.2014"));
            Assert.AreEqual("31 December", l.DatePrint(lang, "31.12.2020"));
            lang = 2;
            Assert.Throws<ArgumentException>(() => l.DatePrint(lang, "31.12.2020"));
        }
        [Test]
        public void Test5()
        {
            LogicWork l = new LogicWork();
            String name = "Dima";
            int lang = 2;
            Assert.Throws<ArgumentException>(() => l.GreatingBuild(lang, name, "14:32", "17.05.2018", 1));
            lang = 0;
            Assert.AreEqual("Язык: Ru \n17 Мая Пн \nДобрый день, Dima", l.GreatingBuild(lang, name, "14:32", "17.05.2018", 1));
            Assert.AreEqual("Язык: Ru \n11 Февраля Вт \nДоброе утро, Dima", l.GreatingBuild(lang, name, "06:20", "11.02.2020", 2));
            Assert.AreEqual("Язык: Ru \n20 Сентября Вс \nДобрый вечер, Dima", l.GreatingBuild(lang, name, "20:32", "20.09.2010", 7));
            Assert.AreEqual("Язык: Ru \n9 Марта Пт \nДоброй ночи, Dima", l.GreatingBuild(lang, name, "02:32", "09.03.2008", 5));
            Assert.AreEqual("Язык: Ru \n31 Декабря Сб \nДоброе утро, Dima", l.GreatingBuild(lang, name, "10:32", "31.12.2021", 6));
            lang = 1;
            Assert.AreEqual("Language: En \n17 May Mon \nGood afternoon, Dima", l.GreatingBuild(lang, name, "14:32", "17.05.2018", 1));
            Assert.AreEqual("Language: En \n11 February Tue \nGood morning, Dima", l.GreatingBuild(lang, name, "06:20", "11.02.2020", 2));
            Assert.AreEqual("Language: En \n20 September Sun \nGood evening, Dima", l.GreatingBuild(lang, name, "20:32", "20.09.2010", 7));
            Assert.AreEqual("Language: En \n9 March Fri \nGood night, Dima", l.GreatingBuild(lang, name, "02:32", "09.03.2008", 5));
            Assert.AreEqual("Language: En \n31 December Sat \nGood morning, Dima", l.GreatingBuild(lang, name, "10:32", "31.12.2021", 6));
        }
    }
}

using lr4;

LogicWork l = new LogicWork();

DateTime now = DateTime.Now;
DayOfWeek dayOfWeek = now.DayOfWeek;
int dayOfWeekNumber = (int)dayOfWeek;
String nowDate = now.ToString("dd.MM.yyyy");
String nowTime = now.ToString("HH:mm:ss");
string username = Environment.UserName;
int language = 2;

Console.WriteLine(l.GreatingBuild(language, username, nowTime, nowDate, dayOfWeekNumber));
String line1 = "";
String line2 = "";
String line3 = "";
bool flag = true;
switch (language)
{
    case (0):
        line1 = "Введите первый катет:";
        line2 = "Введите второй катет:";
        line3 = "Гипотенуза = ";
        break;
    case (1):
        line1 = "Enter the first leg:";
        line2 = "Enter the second leg:";
        line3 = "Hypotenuse = ";
        break;
    default:
        flag = false;
        break;
}
if (flag)
{
    Console.Write(line1);
    int kat1 = int.Parse(Console.ReadLine());
    Console.Write(line2);
    int kat2 = int.Parse(Console.ReadLine());
    Console.WriteLine(line3 + l.FindGipotenusa(kat1, kat2).ToString("0.0000"));
}
else
{
    Console.Write("ERROR");
}

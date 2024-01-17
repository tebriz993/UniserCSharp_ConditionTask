
// See https://aka.ms/new-console-template for more information

#region Task1
using System.Threading.Channels;

Console.Write("Enter one department: ");
string department = Console.ReadLine();
switch (department)
{
    case "HR":
        Console.WriteLine("Human resources department");
        break;
    case "IT":
        Console.WriteLine("Information Technology department");
        break;
    case "Finance":
        Console.WriteLine("Finance department");
        break;
    default:
        Console.WriteLine("There is no such department");
        break;
}
#endregion

#region Task2
Console.Write("Enter your experience: ");
int experience = Convert.ToInt32(Console.ReadLine());

if(experience >= 0 && experience <= 2) Console.WriteLine("Your salary: 2000 AZN");
else if (experience >= 3 && experience < 5) Console.WriteLine("Your salary: 5000 AZN");
else if(experience >= 5 && experience <= 10) Console.WriteLine("Your salary: 7000 AZN");
else if(experience > 10) Console.WriteLine("Your salary: 10000 AZN");
#endregion

#region Task3
Console.Write("Enter time: ");
int time = Convert.ToInt32(Console.ReadLine());

if (time>0 && time<12) Console.WriteLine("Good Morning");
else if (time>=12 && time<=17 ) Console.WriteLine("Good Afternoon");
else if (time>17 && time<=24) Console.WriteLine("Good Evening");
#endregion

#region Task4

Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

double averageValue=(number1+number2+number3)/ 3;
Console.Write(averageValue);
if (averageValue < 20) { Console.WriteLine(" Aktiv"); }
else if (averageValue > 20) { Console.WriteLine(" Deaktiv"); }

#endregion

#region No1_and_No2

Console.WriteLine("Enter first side: ");
int side1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second side: ");
int side2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third side: ");
int side3 = Convert.ToInt32(Console.ReadLine());

//Ucbucagin movcudlugunu yoxlama
if(side1+side2>side3 || side1 + side3 > side2 || side3 + side2 > side1)
{
    Console.WriteLine("Bele ucbucaq movcuddur...");
}
else { Console.WriteLine("Bele ucbucaq movcud deyil..."); }

//Ucbucagin tipini yoxlama
if (side1==side2 && side2==side3)
{
    Console.WriteLine("Beraberterefli ucbucaqdir(hem de beraberyanli)");
}else if(side1 == side2 || side2 == side3 || side1 == side3)
{
    Console.WriteLine("Beraberyanli ucbucaqdir");
}
else
{
    Console.WriteLine("Muxtelifterefli ucbucaqdir");
}
#endregion

#region No3
Console.WriteLine("Enter type of weather: cloudy, sunny or snowy  ");
string typeOfWeather = Console.ReadLine();
switch (typeOfWeather)
{
    case "cloudy":
        Console.WriteLine("It might be cold, you need a jacket.");
        break;
    case "snowy":
        Console.WriteLine("It will be cold, you need a scarf and gloves");
        break;
    case "sunny":
        Console.WriteLine("It will be hot, you can go to beach");
        break;
   
}
#endregion

#region No4
Console.WriteLine("Enter number: ");
int numberOfMonth = Convert.ToInt32(Console.ReadLine());

if(numberOfMonth>12 || numberOfMonth <0)
{
    Console.WriteLine("Eded 1 ve 12 arasinda olmalidir... ");
}
switch (numberOfMonth)
{
    case 1:
        Console.WriteLine("Yanvar");
        break;
    case 2:
        Console.WriteLine("Fevral");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    case 4:
        Console.WriteLine("Aprel");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("Iyun");
        break;
    case 7:
        Console.WriteLine("Iyul");
        break;
    case 8:
        Console.WriteLine("Avqust");
        break;
    case 9:
        Console.WriteLine("Sentyabr");
        break;
    case 10:
        Console.WriteLine("Oktyabr");
        break;
    case 11:
        Console.WriteLine("Noyabr");
        break;
    case 12:
        Console.WriteLine("Dekabr");
        break;


}
#endregion

#region No5
Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

string netice = (num >= 0) ? "Bu musbet ededdir" : "Bu menfi ededdir";
Console.WriteLine(netice);

#endregion

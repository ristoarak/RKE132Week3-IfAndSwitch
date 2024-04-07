int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);//0-6

switch(weekDay) // väärtus midakontrollitakse
{
    case 0: // Case 0 on tegelikult  == if( weekDay  == 0)
        Console.WriteLine(" Its Sunday");
        break;
        case 1:
        Console.WriteLine("Its Monday");
        break;
    case 2:
        Console.WriteLine("Its Tuesday");
        break;
    case 3:
        Console.WriteLine("Its Wednesday");
        break;
    case 4:
        Console.WriteLine("Its Thursday");
        break;
    case 5:
        Console.WriteLine("Its Friday");
        break;
    case 6:
        Console.WriteLine("Its Saturday");
        break;
    default:
        Console.WriteLine("Oops.your calender must be broken!");
        break;
}
Console.WriteLine("Have a niceday!");
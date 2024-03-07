int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);
switch (weekDay) //väärtus, mida kontrollitakse
{
    case 0: //case 0: == if(weekDay) == 0
        Console.WriteLine("On ju pühapäev");
        break;
        case 1:
        Console.WriteLine("On ju esmaspäev");
        break;  
        case 2:
        Console.WriteLine("On ju teisipäev");
        break;
        case 3:
        Console.WriteLine("On ju kolmapäev");
        break;
        case 4:
        Console.WriteLine("On ju neljapäev");
        break;
        case 5:
        Console.WriteLine("On ju reede");
        break;
        case 6:
        Console.WriteLine("On ju laupäev");
        break;
        



}

Console.WriteLine("ilusat päeva"); 

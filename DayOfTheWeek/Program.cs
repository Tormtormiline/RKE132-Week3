
int weekDay  = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0)
{
    Console.WriteLine("IT's Sunday");
}
else if (weekDay == 1)
{
    Console.WriteLine("Esmaspäev");
}
else if (weekDay == 2)
{
    Console.WriteLine("Teisipäev");
}
else if (weekDay == 3)
{
    Console.WriteLine("Kolmapäev");
}
else if (weekDay == 4)
{
    Console.WriteLine("NEljapäev");
}
else if (weekDay == 5)
{
    Console.WriteLine("Reede");
}
else if (weekDay == 6)
{
    Console.WriteLine("Laupäev");
}

Console.WriteLine("Head päeva jätku");



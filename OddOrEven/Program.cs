﻿
Console.WriteLine("Enter number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

Console.WriteLine(result);

if (result != 0)
{
    Console.WriteLine("user number is odd");
} else
{
    Console.WriteLine("user number is even.");
}


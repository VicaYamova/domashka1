Console.Write("Введите пятизначное число:   ");
string? number = Console.ReadLine();

if(number[0]==number[4]&&number[1]==number[3])
{
    Console.WriteLine($"Число: {number} - палиндром");
}

else
{
    Console.WriteLine($"Число: {number} - НЕ палиндром");
}
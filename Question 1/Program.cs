//A PROGRAM THAT PRINTS THE NEXT 20 YEARS

int year = 0;
Console.Write("Enter Any Year: ");

year = Convert.ToInt32(Console.ReadLine());

for (int count = 0; count <= 80; count++)
{
    year++;
    if( year % 400 == 0 || ((year % 4 == 0) && (year % 100 != 0)))
        Console.WriteLine($"Year {year} is a leap year");
}
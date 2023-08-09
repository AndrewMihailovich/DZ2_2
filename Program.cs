Console.Write("Введите число ");
int chislo = Convert.ToInt32(Console.ReadLine());
while (chislo > 999)
{
 chislo = chislo / 10;
}
 if (chislo < 1000 && chislo > 99)
{
   Console.Write("Третье число -> " + chislo % 10); 
}
 else
{
    Console.Write("Третьей цифры нет");
}
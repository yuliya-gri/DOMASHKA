Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

if(x > 99)
{

while (x >= 1000) x = x / 10;

Console.WriteLine("Третья цифра слева");
Console.WriteLine(x % 10);

}
else
{
    Console.WriteLine("Введено некорректное число");
}
    

    
        
    

//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("Это понедельник");
} 
else if(number == 2)
{
    Console.WriteLine("Это вторник");
} 
else if(number == 3)
{
    Console.WriteLine("Это среда");
} 
else if(number == 4)
{
    Console.WriteLine("Это четверг");
} 
else if(number == 5)
{
    Console.WriteLine("Это пятница");
} 
else if(number == 6)
{
    Console.WriteLine("Это суббота");
}
else if(number == 7)
{
    Console.WriteLine("Это воскресенье");
} 
else
{
    Console.WriteLine("Ошибка!!!");
}  

switch(number)
{
    case 1:
    {
    Console.WriteLine("Это понедельник");
    break; 
    } 
    case 2:
    {
      Console.WriteLine("Это вторник");
      break;   
    } 
     case 3:
    {
      Console.WriteLine("Это среда"); 
      break;
    }  
      case 4:
    {
      Console.WriteLine("Это четверг"); 
      break;  
    } 
    case 5:
    {
      Console.WriteLine("Это пятница");
      break;   
    } 
    case 6:
    {
      Console.WriteLine("Это суббота");
      break;   
    }
    case 7:
    {
      Console.WriteLine("Это воскресенье"); 
      break; 
    } 
    case 8:
    {
     Console.WriteLine("Ошибка!!!");   
    break; 
    } 
    }  
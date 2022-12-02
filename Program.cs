Console.WriteLine("Hello again! Please input task number!");
int task = Convert.ToInt32(Console.ReadLine());
if(task == 19) Task19(); 
else if(task == 21) Task21();
else if(task == 23) Task23();
else
{
    Console.WriteLine("Sorry, You didn't give us this task. Please write 19, 21 or 23");
}



void Task19()
{
    Console.WriteLine("Input 5-digit number, please");
    int number = Convert.ToInt32(Console.ReadLine());
    if(Convert.ToString(number)[0] == Convert.ToString(number)[4] && 
    Convert.ToString(number)[1] == Convert.ToString(number)[3])
    {
        Console.WriteLine("Wow, this is a palindrome!");
    }
    else
    {
        Console.WriteLine("This is usual number. Let's try again!");
    }
}
void Task21()
{
    Random rand = new Random();
    int x1 = rand.Next(-10,10);
    int y1 = rand.Next(-10,10);
    int z1 = rand.Next(-10,10);
    int x2 = rand.Next(-10,10);
    int y2 = rand.Next(-10,10);
    int z2 = rand.Next(-10,10);
    Console.WriteLine("The program generated points with the following coordinates:");
    Console.WriteLine($"A ({x1}, {y1}, {z1})");
    Console.WriteLine($"B ({x2}, {y2}, {z2})");
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)
    + Math.Pow((z1 - z2), 2));
    Console.WriteLine($"The distance between A and B is {result}");
}
void Task23()
{
    Console.WriteLine("Input any number");
    int number = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i <= number; i++)
    {
        Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
    }

}
    


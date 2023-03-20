int r = 0;
while(true)
{
    var dt = DateTime.Now;
    r = new Random().Next();
    Console.WriteLine($"{dt}: Hello, World! This is random number: {r}"); //TODO: Set a breakpoint
    Thread.Sleep(5000);
}
string hello = "hello, world1";
int counter = 0;
for (int i = 0;i < hello.Length; i++) 
{
    if (hello [i] == 'l') 
    {
        counter++;
    }
}
Console.WriteLine($"There are {counter} l's in the string { hello}");
//Random rnd = new Random();

//int RandomColor = rnd.Next(0, colors.Length);

//Console.WriteLine($"You should wear {colors[RandomColor]}");

object data = "Merhaba"; // string
int a = 50; 
data = a; // boxing -> int -> object
var b = (int)data;  // unboxing object -> int
b++;
Console.WriteLine(b);

if(data is string)
{
    Console.WriteLine("Veri türü string'dir.");
}
else if (data is int)
{
    Console.WriteLine("Veri türü int'dir.");
}
else
{
    Console.WriteLine("Veri başka bir tiptedir.");
}


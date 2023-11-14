

int input;
Console.WriteLine("Enter Integer number: ");
string temp=Console.ReadLine();

bool IsParsed=Int32.TryParse(temp, out input);

if (IsParsed)
{
    bool IsOdd = input % 2 == 1;
    if (IsOdd)
    {
        Console.WriteLine($"Entered number {input} Is Odd");
    }
    else {
        Console.WriteLine($"Entered number {input} Is not Odd, it's even");
    }
}
else {
    Console.WriteLine("Invalid Input");
    }

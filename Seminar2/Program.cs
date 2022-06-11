
/* int FindMaxPart(int num)
{
    int dec, ed;
    if(num >= 10 && num <= 99)
    {
        dec = num /10;
        ed = num % 10;

        if(dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else
    {
            return -1;
    }
}

// c = a % b
Console.Write("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a);

if(result == -1)
{
    Console.WriteLine("Your number is not a two-digit!");
}
else
{
Console.WriteLine("Bigger number of " + a + " is " + result);
} */

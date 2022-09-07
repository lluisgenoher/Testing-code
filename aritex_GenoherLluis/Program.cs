int numLine = 0;
int firstNumber = -1;
List<int> rangeNumbers = new List<int>();
String[] file = File.ReadAllLines(@"C:\Users\Lluis\source\repos\aritex_GenoherLluis\aritex_GenoherLluis\numbers.txt");
Int32 length = file.Length;

foreach (string line in file)
{  
    int number = Int32.Parse(line);


    if (!isSameLine(number))
    {
        printRange();

        resetNumbers();

        firstNumber = number;
        numLine = number+1;

    }
    else
    {

        if (firstNumber == -1) firstNumber = number;
        else
        {
            if (isSameLine(number))
            {
                rangeNumbers.Add(number);
            }
        }
        numLine++;

    }

}  

Boolean isSameLine(int number)
{
    return number == numLine;
}
void resetNumbers()
{
    firstNumber = -1;
    rangeNumbers.Clear();
}

void printRange()
{
    if (!rangeNumbers.Any())
    {
        System.Console.WriteLine("[" + firstNumber + "]");
    }
    else
    {
        System.Console.WriteLine("[" + firstNumber + "..." + rangeNumbers.Last() + "]");
    }
    if (firstNumber == (file.Length + 1))
    {

        System.Console.WriteLine("[" + firstNumber + "]");
    }
}


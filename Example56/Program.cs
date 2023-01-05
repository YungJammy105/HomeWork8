using MyMethod;

MyGenerate gen = new ();

int[,] myArr = gen.ArrayGenDI();
MyMethod.MyMethod.Print(myArr);

int maxString = MaxString(myArr);
MyMethod.MyMethod.Print($"Минимальную сумму имеет {maxString} строка");

int MaxString(int[,] usersArray)
{
    int length = usersArray.GetLength(0);
    int maxStringInd = 0;
    for (int i = 0; i < length; i++)
    {
        if (StringSum(usersArray, i) < StringSum(usersArray, maxStringInd))
        {
            maxStringInd = i;
        }
    }
    return maxStringInd + 1;
}

int StringSum(int[,] usersArray, int stringIndex)
{
    int sum = 0;
    for (int i = 0; i < usersArray.GetLength(1); i++)
    {
        sum += usersArray[stringIndex, i];
    }
    return sum;
}


using MyMethod;

MyGenerate gen = new MyGenerate();

int sizeRows = MyMethod.MyMethod.IntInput("Введите число строк в массиве");
int sizeColumns = MyMethod.MyMethod.IntInput("Введите число столбцов в массиве");
int startX = 1;
int startY = 1;
int startValue = MyMethod.MyMethod.IntInput("Введите стартовое значение");
int[,] usersArray = new int[sizeRows, sizeColumns];


int[,] baseArray = MkBaseArrayFrom(usersArray);


int[,] spiral = SpiralArray(baseArray, startX, startY, startValue, 1);
MyMethod.MyMethod.Print(spiral);


int[,] SpiralArray(int[,] baseArray, int startX, int startY, int startValue, int direction)
{
    if (baseArray[startX, startY] == 0)
    {
        baseArray[startX, startY] = startValue;
        startValue++;


        if (direction == 1 && baseArray[startX, startY + 1] == 0)
        {
            direction = 1;
        }
        else if (direction == 1 && baseArray[startX, startY + 1] != 0)
        {
            direction = 2;
        }
        else if (direction == 2 && baseArray[startX + 1, startY] == 0)
        {
            direction = 2;
        }
        else if (direction == 2 && baseArray[startX + 1, startY] != 0)
        {
            direction = 3;
        }
        else if (direction == 3 && baseArray[startX, startY - 1] == 0)
        {
            direction = 3;
        }
        else if (direction == 3 && baseArray[startX, startY - 1] != 0)
        {
            direction = 4;
        }
        else if (direction == 4 && baseArray[startX - 1, startY] == 0)
        {
            direction = 4;
        }
        else if (direction == 4 && baseArray[startX + 1, startY] != 0)
        {
            direction = 1;
        }

        switch (direction)
        {
            case 1: // right
                return SpiralArray(baseArray, startX, startY + 1, startValue, 1);
            case 2: // down
                return SpiralArray(baseArray, startX + 1, startY, startValue, 2);
            case 3: // left
                return SpiralArray(baseArray, startX, startY - 1, startValue, 3);
            case 4: // up
                return SpiralArray(baseArray, startX - 1, startY, startValue, 4);
        }
    }


    int[,] spiralArray = new int[baseArray.GetLength(0) - 2, baseArray.GetLength(1) - 2];
    for (int i = 1; i < baseArray.GetLength(0) - 1; i++)
    {
        for (int j = 1; j < baseArray.GetLength(1) - 1; j++)
        {
            spiralArray[i - 1, j - 1] = baseArray[i, j];
        }
    }
    return spiralArray;
}


int[,] MkBaseArrayFrom(int[,] usersArray)
{
    int[,] baseArray = new int[usersArray.GetLength(0) + 2, usersArray.GetLength(1) + 2];
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        for (int j = 0; j < baseArray.GetLength(1); j++)
        {
            if (j == 0 || i == 0 || j == baseArray.GetLength(1) - 1 || i == baseArray.GetLength(0) - 1)
            {
                baseArray[i, j] = 1;
            }
        }
    }
    return baseArray;
}
using MyMethod;

MyGenerate gen = new MyGenerate();
Random rnd = new Random();

int[,,] myArr = ArrayGenTI();
Print(myArr);


int[,,] ArrayGenTI()
    {
        int rows = MyMethod.MyMethod.IntInput("число строк");
        int columns = MyMethod.MyMethod.IntInput("число столбцов");
        int depth = MyMethod.MyMethod.IntInput("глубина массива");
        int min = 10;
        int max = 99;
        int element = rnd.Next(min,max);
        int[,,] array = new int[rows, columns, depth];
        for (int i = 0; i < rows; i++)
        {
            for (int j= 0; j < columns; j++){
                for (int k= 0; k < depth; k++){
                    while (!(unicumInArr(array, element))){
                        element = rnd.Next(min,max);
                    }
                    array[i,j,k] = element;
                }
            }  
        }
        
        return array;
    }

    bool unicumInArr (int[,,] usersArray, int num){
        for (int i = 0; i < usersArray.GetLength(0); i++)
        {
            for (int j= 0; j < usersArray.GetLength(1); j++){
                for (int k= 0; k < usersArray.GetLength(2); k++){
                    if (usersArray[i,j,k] == num) return false;
                }
            }  
        }
        return true;
    }

    void Print (int[,,] usersArray){
        for (int i = 0; i < usersArray.GetLength(0); i++)
        {
            for (int j= 0; j < usersArray.GetLength(1); j++){
                for (int k= 0; k < usersArray.GetLength(2); k++){
                    Console.Write($"| {usersArray[i,j,k]} ({i},{j},{k}) |");
                }
                Console.WriteLine();
            }
            Console.WriteLine();  
        }
        Console.WriteLine();
    }
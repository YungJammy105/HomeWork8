using MyMethod;

MyGenerate gen = new MyGenerate();


int[,] matrix1 = gen.ArrayGenDI();
MyMethod.MyMethod.Print(matrix1);
int[,] matrix2 = gen.ArrayGenDI();

int[,] productMatrix = MatrixProduct(matrix1,matrix2);
MyMethod.MyMethod.Print(" -----------");
MyMethod.MyMethod.Print(matrix1);
MyMethod.MyMethod.Print("      *     ");
MyMethod.MyMethod.Print(matrix2);
MyMethod.MyMethod.Print(" ===========");
MyMethod.MyMethod.Print(productMatrix);

int[,] MatrixProduct (int[,] matrix1, int[,] matrix2){
    int[,] product = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    MyMethod.MyMethod.Print("arr created");
    for (int i=0; i<product.GetLength(0); i++){

        for (int j=0; j<matrix1.GetLength(1); j++){

            for (int k=0; k<matrix2.GetLength(0); k++){

                product[i,j]+= matrix1[i,j]*matrix2[k,i];

            }
        }
    }
    return product;
}
// לעשות מערך דו ממדי של 5 על 5, להציב ערכים אקראיים ואז לאפס את האלכסונים עם לולאה

int[,] matrix = new int[5, 5];
Random random = new Random();

for (int row = 0;row < 5; row++)
{
    for(int col = 0; col < 5; col++)
    {  
        matrix[row,col] = random.Next(9);

        if (row == col || row + col == 4) //sum of row and col is 4 for the secound \ and row = col its make the first \
            matrix[row, col] = 0;

        Console.Write("" + matrix[row,col] + " ");
    }
    Console.WriteLine();
}




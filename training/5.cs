using System;

class training5
{
    public static void Main(String[] args)
    {
        char[,] arrayXO = new char[3, 3];

        for (int i = 0; i < arrayXO.GetLength(0); i++)
        {
            for (int j = 0; j < arrayXO.GetLength(1); j++)
            {
                if (i % 2 == 0)
                {
                    if (j % 2 == 0)
                    {
                        arrayXO[i, j] = 'x';
                    }
                    else
                    {
                        arrayXO[i, j] = 'o';
                    }
                }
                else
                {
                    if (j % 2 == 0)
                    {
                        arrayXO[i, j] = 'o';
                    }
                    else
                    {
                        arrayXO[i, j] = 'x';
                    }
                }
            }
        }

        for (int i = 0; i < arrayXO.GetLength(0); i++)
        {
            for (int j = 0; j < arrayXO.GetLength(1); j++)
            {
                Console.Write(arrayXO[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
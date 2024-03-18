namespace lekcja_28._11._2023;

class Program
{
    static void Main(string[] args)
    {
        int[,] ints = new int[4,3];
        // Console.WriteLine(ints.Rank); // 2
        // Console.WriteLine(ints.GetLength(0)); // 4
        // Console.WriteLine(ints.GetLength(1)); // 3

        // for (int i=0; i < ints.GetLength(0); i++){
        //     for (int j=0; j < ints.GetLength(1); j++){
        //         Console.Write($"ints[{i},{j}]={ints[i, j]} ");
        //     }   
        //     Console.WriteLine();
        // }

        int[,,] cubes = new int[4, 3, 2];

        for (int i = 0; i < cubes.GetLength(0); i++)
        {
            Console.WriteLine($"cubes[{i}]");
            for (int j = 0; j < cubes.GetLength(1); j++)
            {   
                Console.WriteLine($"\tcubes[{i},{j}]");
                for (int k = 0; k < cubes.GetLength(2); k++)
                {
                    Console.WriteLine($"\t\tcubs[{i}, {j}, {k}] {cubes[i,j,k]} \t");
                }
                Console.WriteLine();
            }
        }
        
    }
}

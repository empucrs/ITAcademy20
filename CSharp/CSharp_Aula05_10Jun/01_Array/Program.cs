namespace _01_Array;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nvetor 1D");
        int [] vetor1D = new int[] { 1, 2, 5, 9, 3};
        Console.WriteLine("Length="+vetor1D.Length);
        Console.WriteLine("Rank="+vetor1D.Rank);
        for(int nivel=0; nivel<vetor1D.Rank;nivel++)
            Console.WriteLine("  N["+nivel+"]= "+vetor1D.GetLength(nivel));
        foreach(var item in vetor1D)
            Console.WriteLine("" + item);

        Console.WriteLine("\nvetor 2D");
        int [,] vetor2D = {{1,3},{5,7},{9,11}};
        Console.WriteLine("Length="+vetor2D.Length);
        Console.WriteLine("Rank="+vetor2D.Rank);
        for(int nivel=0; nivel<vetor2D.Rank;nivel++)
            Console.WriteLine("  N["+nivel+"]= "+vetor2D.GetLength(nivel));
        foreach(var item in vetor2D)
            Console.WriteLine("" + item);

        Console.WriteLine("\nvetor 3D");
        int [,,] vetor3D = { 
            {
                {1,3,2},
                {5,7,4}
            },
            {
                {9,11,8}, 
                {13,15,12}
            },
            {
                {17,19,16}, 
                {21,23,20}
            },
            {
                {25,27,24}, 
                {29,31,28}
            },
             
        };


        Console.WriteLine("Length="+vetor3D.Length);
        Console.WriteLine("Rank="+vetor3D.Rank);
        for(int nivel=0; nivel<vetor3D.Rank;nivel++)
            Console.WriteLine("  N["+nivel+"]= "+vetor3D.GetLength(nivel));
        foreach(var item in vetor3D)
            Console.WriteLine("" + item);

        Console.WriteLine("\nvetor 2D Jagged");
        int[][] vetor2DJagged = { 
                new int[] {1,2,3}, 
                new int[] {4,5}, 
                new int[] {6,7,8,9,10,11,12,13}
            };
        Console.WriteLine("Length="+vetor2DJagged.Length);
        Console.WriteLine("Rank="+vetor2DJagged.Rank);
        for(int nivel=0; nivel<vetor2DJagged.Rank;nivel++)
            Console.WriteLine("  N["+nivel+"]= "+vetor2DJagged.GetLength(nivel));
        foreach(var item in vetor2DJagged)
            Console.WriteLine("" + item);

        for(int lin=0; lin<vetor2DJagged.Length; lin++){
            Console.WriteLine("V2DJagged["+lin+"]: ");
            for(int col=0; col<vetor2DJagged[lin].Length; col++)
                Console.WriteLine("  V2DJagged["+lin+"]["+col+"]: "+vetor2DJagged[lin][col]);
        }

        Console.WriteLine("\nvetor 3D Jagged");
        int[][][] vetor3DJagged = { 
                new int[][] {
                    new int []{1,2,3},
                    new int [] {4,5}, 
                },
                new int[][] {
                    new int [] {6,7,8,9,10,11,12,13}
                },
                new int[][] {
                    new int [] {14,15,16},
                    new int [] {17,18,19,20,21},
                    new int [] {22}
                }
            };
        Console.WriteLine("Length="+vetor3DJagged.Length);
        Console.WriteLine("Rank="+vetor3DJagged.Rank);
        for(int nivel=0; nivel<vetor3DJagged.Rank;nivel++)
            Console.WriteLine("  N["+nivel+"]= "+vetor3DJagged.GetLength(nivel));
        foreach(var item in vetor3DJagged)
            Console.WriteLine("" + item);

        for(int lin=0; lin<vetor3DJagged.Length; lin++){
            Console.WriteLine("V3DJagged["+lin+"]: ");
            for(int col=0; col<vetor3DJagged[lin].Length; col++){
                Console.WriteLine("  V3DJagged["+lin+"]["+col+"]: ");
                for(int lvl=0; lvl<vetor3DJagged[lin][col].Length; lvl++)
                    Console.WriteLine("    V3DJagged["+lin+"]["+col+"]["+lvl+"]: "+vetor3DJagged[lin][col][lvl]);
            }
        }

    }
}

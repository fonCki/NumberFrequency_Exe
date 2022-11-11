namespace ConsoleApp1;

public static class Tools {

    public static int[] Solution(int[] A) {
        int[] Result = new int[A.Max() + 1]; // Define an array with a lenght on Max value in f
        foreach (var v in A) { //Insert the values
            Result[v]++;
        }

        return Result;
    }

    public static void printBasic(int[] result) {
        Console.Write("Frequency: ");
        foreach (var v in result) {
            Console.Write(v + ", ");
        }

        Console.WriteLine();
        Console.Write("Number:    ");
        for (int i = 0; i < result.Length; i++) {
            Console.Write(i + ", ");
        }

        Console.WriteLine();
    }

    public static void printWithAs(int[] result) {
        var numberOfLines = result.Max();
        
        for (int i = numberOfLines; i > 0; i--) { // print * or space for each line
            foreach (var value in result) {
                Console.Write(value >= i ? "* " : "  ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < result.Length; i++) { // print the number of the line
            Console.Write(result[i] + " ");
        }
 
        Console.WriteLine();
    }
}
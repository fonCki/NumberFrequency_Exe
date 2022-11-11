// See https://aka.ms/new-console-template for more information



using System.Collections;
using System.ComponentModel.Design;
using System.Security.AccessControl;
using ConsoleApp1;

class Program {
    public static void Main(string[] args) {
        
        //int[] A = {1, 4, 1, 5, 8, 1, 3, 5, 1, 4, 1, 3, 7, 2};
        int[] A = Array.ConvertAll(args, s => int.Parse(s));
        
        int[] R = Tools.Solution(A);
        Tools.printBasic(R);
        Tools.printWithAs(R);
    }
}
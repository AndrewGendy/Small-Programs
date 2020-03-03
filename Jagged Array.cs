using System;

namespace test {
    class Program {
        static void Main(string[] args) {

            string[] students = new string[3];
            students[0] = "Andrew";
            students[1] = "Hany";
            students[2] = "Ali";

            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            jaggedArray[0][0] = "Bachelor";
            jaggedArray[0][1] = "Masters";
            jaggedArray[0][2] = "Doctorate";

            jaggedArray[1][0] = "Bachelor";

            jaggedArray[2][0] = "Bachelor";
            jaggedArray[2][1] = "Masters";

            for (int i = 0; i < jaggedArray.Length; i++) {
                Console.WriteLine(students[i] + "\n-------");
                for (int j = 0; j < jaggedArray[i].Length; j++) {
                    Console.WriteLine(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }


        }
    }
}

namespace Module_07
{
    internal class Program
    {/*06 Binary alphabet

        Read in a number and create a sequence of all binary alphabetical representations from 1 up to the entered number. 
        A binary alphabetical string is a string where the bits of the binary representation determine whether a character is shown. 
        For example, a binary alphabetical representation of 100011101 would be 'aefgi' (important: the bit count is never more than 26.)

        Eg: 8
        1 = 1    a
        2 = 10    a
        3 = 11    ab
        4 = 100    a
        5 = 101    ac
        6 = 110    ab
        7 = 111    abc
        8 = 1000    a

        Try to solve each exercise in different ways, always start from the naive approach first (brute force), and then try to work more efficiently based on what we saw in the lesson! Think what Big(O) could be!

        Input/Output
        input:
        8
        output:
        a a ab a ac ab abc a 

        input:
        20
        output:
        a a ab a ac ab abc a ad ac acd ab abd abc abcd a ae ad ade ac */
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment();
            string input = "8";//Console.ReadLine();
            int number = int.Parse(input);
            string output = assignment.BinaryAlpha(number);
            Console.WriteLine("output == " +output);
            Console.WriteLine();
            Console.WriteLine("result == "+assignment.result);
            Console.WriteLine("Memo" + assignment.Memoisation(number, new string[number+1]));
            Console.WriteLine(assignment.flip());
        }
    }
}
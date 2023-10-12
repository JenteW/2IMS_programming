using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module_02
{
    internal class Program
    {

        /*You're in a space team and got mixed-up signals from far away. Each signal has a timemark and a part of a message. Sort to order the signals by time and find the hidden message. Try to solve each exercise in different ways, always start from the naive approach first (brute force), and then try to work more efficiently based on what we saw in the lesson! Think what Big(O) could be!

Catch: you are only allowed to use the System-namespace without the Array-class! (so no Array.Sort, Array.Reverse etc...)

CodeGrade Setup = .Net framework 6.0

Input/Output
input:
TS: 6, fragment: "system"
TS: 2, fragment: "Hello"
TS: 4, fragment: "our"
TS: 1, fragment: "Interstellar"
TS: 3, fragment: "from"
TS: 5, fragment: "solar"
output:
Interstellar Hello from our solar system

input:
TS: 8, fragment: "star"
TS: 1, fragment: "Greetings"
TS: 5, fragment: "our"
TS: 2, fragment: "Earthlings,"
TS: 3, fragment: "we"
TS: 4, fragment: "orbit"
output:
Greetings Earthlings we orbit our star*/

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Assignment assignment = new Assignment();
            Console.WriteLine(assignment.Space(input));
        }
    }
}
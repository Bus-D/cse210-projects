using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment _assignment = new Assignment("Samuel Bennett", "Multiplication");

        _assignment.GetSummary();

        MathAssignment _mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        _mathAssignment1.GetHomeWorkList();

        WritingAssignment _writing1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        _writing1.GetWritingInfo();
    }
}
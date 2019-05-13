using System;

namespace proj2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool doContinue;
            do
            {


                DoWork();
                Console.WriteLine("Do you want to cntinue?(y/n)");
                char response = char.Parse(Console.ReadLine()); 
                if (response == 'y')
                {
                    doContinue = true;
                }
                else
                {
                    doContinue = false;
                }
            } while (doContinue);

            Console.ReadLine();

        }

        static void DoWork()
        {
            Console.WriteLine("Enter the mark");
            int mark = int.Parse(Console.ReadLine());


            string grade = GradeCalculation(mark);

            Console.WriteLine("The grate is {0}:", grade);
        }


        static string GradeCalculation(int mark)
        {
            string grade;
            if (mark >= 80 && mark <= 100)
            {
                grade = "A";
            }
            else if (mark >= 70 && mark <= 79)
            {
                grade = "B";
            }
            else if (mark >= 60)
            {
                grade = "C";
            }
            else if (mark >= 50 && mark <= 59)
            {
                grade = "D";
            }
            else if (mark >= 0 && mark < 49)
            {
                grade = "F";
            }
            else
            {
                grade = "wrong mark";
            }
            return grade;
        }
    }

}



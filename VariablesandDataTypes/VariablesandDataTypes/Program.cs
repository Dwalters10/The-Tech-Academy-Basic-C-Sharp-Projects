using System;


namespace StudentReport
    
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("What Course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need Help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("how many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

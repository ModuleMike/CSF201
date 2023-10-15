namespace AboutMe
{
    public class Printer
    {
        public static void PrintHeader()
            {
                Console.Clear();
                Console.WriteLine("About You");
                Console.WriteLine("============================");
            }   
        public static void PrintAboutMe(string fName,string lName,DateTime dOB,int age,string status)
        {
            Console.WriteLine($"Name: {lName}, {fName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"DOB: {dOB:d}");
            Console.WriteLine($"Marital Status (S)ingle, (M)arried: {status}");
        }
    }
}
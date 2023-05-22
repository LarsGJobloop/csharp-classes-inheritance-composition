class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Starting Program");

        // Here we are creating an instance of our console logger
        // Logger.ILogger log = new Logger.Console();

        // Due to us using an interface and implementing
        // different versions of the logger we can easily
        // swap the console logger out for a file logger
        // But we do need to decide where to store our logfiles
        string logDirectory = "/logs";
        string logFile = "/log.txt";
        System.Console.WriteLine($"\nLogging to file {"." + logDirectory + logFile}\n");

        Logger.ILogger log = new Logger.File("." + logDirectory + logFile);

        // Place to store input string
        string? input;

        // Simple loop to query for input and logging that
        // Needs to be forecfully shutdown
        while (true)
        {
            // Logs an INFO message
            System.Console.WriteLine("\nPlease enter a INFO message, finish with 'Enter'");
            input = System.Console.ReadLine();

            if (input == null)
            {
                System.Console.WriteLine("\nBlank meassages are not accepted");
            }
            else
            {
                log.Info(input);
            }

            // Logs an WARN message
            System.Console.WriteLine("\nPlease enter a WARN message, finish with 'Enter'");
            input = System.Console.ReadLine();

            if (input == null)
            {
                System.Console.WriteLine("\nBlank meassages are not accepted");
            }
            else
            {
                log.Warn(input);
            }

            // Logs an ERROR message
            System.Console.WriteLine("\nPlease enter a ERROR message, finish with 'Enter'");
            input = System.Console.ReadLine();

            if (input == null)
            {
                System.Console.WriteLine("\nBlank meassages are not accepted");
            }
            else
            {
                log.Error(input);
            }
        }

    }
}
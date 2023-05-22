namespace Logger
{
  // This is a description of what methods and their signature
  // a class implementing the ILogger interface is required to have
  interface ILogger
  {
    public void Info(string message);
    public void Warn(string message);
    public void Error(string message);
  }

  // This class **implements** the ILogger interface
  // Notice the ":" syntaxt
  // For this example we are logging the message to the console
  class Console : ILogger
  {
    public void Info(string message)
    {
      System.Console.WriteLine(message);
    }
    public void Warn(string message)
    {
      System.Console.WriteLine(message);
    }
    public void Error(string message)
    {
      System.Console.WriteLine(message);
    }
  }

  // This class also **implements** the ILogger interface
  // We can have multiple different implementation of the same interface
  // which allows us to extend or chnage the functioanlity of
  // our original program with ease
  // For this example we are logging the message to the a file
  class File : ILogger
  {
    private string logPath;
    
    public File(string logFilePath)
    {
      logPath = logFilePath;
    }

    public void Info(string message)
    {
      using (System.IO.StreamWriter writer = new System.IO.StreamWriter(logPath))
      {
        writer.WriteLine(message);
      }}

    public void Warn(string message)
    {
      using (System.IO.StreamWriter writer = new System.IO.StreamWriter(logPath))
      {
        writer.WriteLine(message);
      }}

    public void Error(string message)
    {
      using (System.IO.StreamWriter writer = new System.IO.StreamWriter(logPath))
      {
        writer.WriteLine(message);
      }}     
  }
}
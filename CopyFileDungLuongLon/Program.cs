public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter source file");
        string sourcePath = Console.ReadLine();

        Console.WriteLine("Enter file Destination");
        string destinationPath = Console.ReadLine();

        FileInfo source = new FileInfo(sourcePath);
        FileInfo destination = new FileInfo(destinationPath);
        try
        {
            CopyFileUsingFileInfor(source,destination);
            Console.WriteLine("File copy");
        }
        catch (System.Exception e)
        {
            Console.WriteLine("Not copy");
            Console.WriteLine(e.Message);
            throw;
        }
    }

    private static void CopyFileUsingFileInfor(FileInfo source, FileInfo destination)
    {
        source.CopyTo(destination.FullName, true);
    }
}
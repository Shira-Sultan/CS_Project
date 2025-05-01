//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;


namespace Tools;

public static class LogManager
{
    private static string path = "Log";

    private static string getfolderPath()
    {
        string filePath = @$"{path}\{DateTime.Now.Month}_{DateTime.Now.Year}";
        return filePath;
    }

    private static string getfilePath()
    {
        //string pathToAddFile = getfolderPath();
        //string filePath = @$"{pathToAddFile}\Log_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}.txt";
        //return filePath;
        return @$"{getfolderPath()}\Log_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}.txt";
    }  

    public static void WriteToLog(string projectName, string func, string message)
    {
        //אם לא קיימת תקייה
        if (!Directory.Exists(getfolderPath()))
        {
            Directory.CreateDirectory(getfolderPath());
        }
        //אם לא קיים קובץ
        if (!File.Exists(getfilePath()))
        {
            File.Create(getfilePath()).Dispose();
        }

        using (StreamWriter sw = new StreamWriter(getfilePath(), true))
        {
            sw.WriteLine($"{DateTime.Now}   {projectName}.{func}:\t{message}");
        }
    }

    public static void removeOldFolders()
    {
        string[] subDirectories = Directory.GetDirectories("path");
        DateTime twoMonthsAgo = DateTime.Now.AddMonths(-2); // חישוב חודשיים אחורה

        foreach (string subDirectory in subDirectories)
        {
            if (DateTime.TryParse(subDirectory, out DateTime folderDate))
            {
                // בדיקה אם התאריך ישן מחודשיים
                if (folderDate < twoMonthsAgo)
                {
                    try
                    {
                        Directory.Delete(subDirectory, true); // true למחיקת כל התוכן
                        Console.WriteLine($"Deleting directory: {subDirectory}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error deleting directory {subDirectory}: {ex.Message}");
                    }
                }
            }
        }
    }

}



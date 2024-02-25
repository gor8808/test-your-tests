namespace ConsoleApp;

public class Utilities
{
    public static bool IsPositive(int number)
    {
        if (number >= 0 && number <= 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
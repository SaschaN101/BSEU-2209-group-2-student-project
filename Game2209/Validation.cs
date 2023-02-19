using System;

public static class Validation
{
    private static string equipment = "htalwq";
    private static string level = "123";

    public static bool ValidationEquipment(char enterSting)
    {
        int indexStr = equipment.IndexOf(enterSting);
        if (indexStr >= 0)
        {
            return true;
        }
        else { return false; }         
    }
    
    public static bool ValidationLevel(char enterSting)
    {
        int indexStr = level.IndexOf(enterSting);
        if (indexStr >= 0)
        {
            return true;
        }
        else { return false; }
    }

}
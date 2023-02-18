using System;

public static class Validation
{
    private static string equipment = "htalw";
    private static string level = "123";

    public static bool validationEquipment(char enterSting)
    {
        int indexStr = equipment.IndexOf(enterSting);
        if (indexStr >= 0)
        {
            return true;
        }
        else { return false; }         
    }
    
    public static bool validationLevel(char enterSting)
    {
        int indexStr = level.IndexOf(enterSting);
        if (indexStr >= 0)
        {
            return true;
        }
        else { return false; }
    }

}
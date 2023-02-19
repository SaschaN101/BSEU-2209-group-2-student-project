using System;

public static class Validation
{
    private static string equipment = "htalwq";
    private static string level = "123";
    private static string fightRaund = "htalw";

    static bool ValidationStr(char enterSting, string str)
    {
        int indexStr = str.IndexOf(enterSting);
        if (indexStr >= 0)
        {
            return true;
        }
        else { return false; }
    }

    public static bool ValidationEquipment(char enterSting)
    {
        return ValidationStr(enterSting, equipment);
    }
    
    public static bool ValidationLevel(char enterSting)
    {
        return ValidationStr(enterSting, level);
        
    }

    public static bool ValidationfightRaund(string enterSting)
    {
        if (enterSting.Length > 1) return false;
        return ValidationStr(enterSting[0], fightRaund);
    }
}
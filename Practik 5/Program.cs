using System;

public class StringComparisonExample
{
    public static void Main(string[] args)
    {
        string str1 = "Love";
        string str2 = "Love";
        string str3 = "Hi!";
        string str4 = "Vlad";
        Console.WriteLine($"Compare(\"{str1}\", \"{str2}\"): {string.Compare(str1, str2)}");       
        Console.WriteLine($"Compare(\"{str1}\", \"{str4}\"): {string.Compare(str1, str4)}");       
        Console.WriteLine($"Equals(\"{str1}\", \"{str2}\"): {str1.Equals(str2)}");             
        Console.WriteLine($"Equals(\"{str1}\", \"{str4}\"): {str1.Equals(str4)}");             
        Console.WriteLine($"CompareOrdinal(\"{str1}\", \"{str2}\"): {string.CompareOrdinal(str1, str2)}");
        Console.WriteLine($"CompareOrdinal(\"{str1}\", \"{str4}\"): {string.CompareOrdinal(str1, str4)}");
        Console.WriteLine($"IndexOf(\"world\" in \"{str3}\"): {str3.IndexOf("world")}");     
        Console.WriteLine($"Contains(\"world\" in \"{str3}\"): {str3.Contains("world")}");     
        Console.WriteLine($"str1 == str2: {str1 == str2}");                                  
        Console.WriteLine($"str1 == str4: {str1 == str4}");                                   
    }
}



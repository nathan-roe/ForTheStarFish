using System;
using System.IO;
using System.Collections.Generic;
namespace PassportProcessingP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] lines = File.ReadAllLines("./passports.bat");
            int i = 0;
            int valid = 0;
            // needs to be 7
            int validPassCount = 0;
            List<string> passport = new List<string>();
            while(i < lines.Length)
            {
                if(lines[i].Length > 0)
                {
                    passport.Add(lines[i]);
                }
                else
                {
                    string newPass = String.Join(" ", passport.ToArray());
                    // byr validation
                    if(newPass.Contains("byr:"))
                    {   
                        int byrIdx = newPass.IndexOf("byr:");
                        string byrStr = newPass.Substring(byrIdx+4, 4);
                        int byr = Convert.ToInt32(byrStr);
                        // System.Console.WriteLine(byr);
                        if(byr >= 1920 && byrIdx <= 2002)
                        {
                            // validPassCount++;
                        }
                    }
                    // iyr validation
                    if(newPass.Contains("iyr:"))
                    {   
                        int iyrIdx = newPass.IndexOf("iyr:");
                        string iyrStr = newPass.Substring(iyrIdx+4, 4);
                        int iyr = Convert.ToInt32(iyrStr);
                        System.Console.WriteLine(iyr);
                        if(iyr >= 2010 && iyrIdx <= 2020)
                        {
                            // validPassCount++;
                        }
                    }
                    // eyr validation
                    if(newPass.Contains("eyr:"))
                    {   
                        int eyrIdx = newPass.IndexOf("eyr:");
                        string eyrStr = newPass.Substring(eyrIdx+4, 4);
                        int eyr = Convert.ToInt32(eyrStr);
                        System.Console.WriteLine(eyr);
                        if(eyr >= 2020 && eyrIdx <= 2030)
                        {
                            // validPassCount++;
                        }
                    }
                    // hgt validation 
                    if(newPass.Contains("hgt:"))
                    {   
                        int hgtIdx = newPass.IndexOf("hgt:");
                        string hgtStr = newPass.Substring(eyrIdx+4, 4);
                        int eyr = Convert.ToInt32(eyrStr);
                        System.Console.WriteLine(eyr);
                        if(eyr >= 2020 && eyrIdx <= 2030)
                        {
                            // validPassCount++;
                        }
                    }
                    // hcl validation
                    // ecl validation
                    // pid validation
                    if(newPass.Contains("byr:") && newPass.Contains("iyr:") && newPass.Contains("eyr:") && newPass.Contains("hgt:") && newPass.Contains("hcl:") && newPass.Contains("ecl:") && newPass.Contains("pid:"))
                    {
                        // System.Console.WriteLine($"valid: {newPass}");
                        valid++;
                    }
                    else
                    {
                        // System.Console.WriteLine($"not valid: {newPass}");
                    }
                    passport = new List<string>();
                    System.Console.WriteLine(validPassCount);
                    validPassCount = 0;

                }
                i++;
            }
            if(lines[lines.Length - 1].Length > 0)
            {
                string newPass = String.Join(" ", passport.ToArray());
                if(newPass.Contains("byr:") && newPass.Contains("iyr:") && newPass.Contains("eyr:") && newPass.Contains("hgt:") && newPass.Contains("hcl:") && newPass.Contains("ecl:") && newPass.Contains("pid:"))
                {
                    // System.Console.WriteLine($"valid: {newPass}");
                    valid++;
                }
                else
                {
                    // System.Console.WriteLine($"not valid: {newPass}");
                }
            }
            // System.Console.WriteLine($"The number valid is: {valid}");
        }
    }
}

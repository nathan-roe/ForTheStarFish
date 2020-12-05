using System;
using System.IO;
using System.Collections.Generic;
namespace PassportProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] lines = File.ReadAllLines("./passports.bat");
            int i = 0;
            int valid = 0;
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
                    if(newPass.Contains("byr:") && newPass.Contains("iyr:") && newPass.Contains("eyr:") && newPass.Contains("hgt:") && newPass.Contains("hcl:") && newPass.Contains("ecl:") && newPass.Contains("pid:"))
                    {
                        System.Console.WriteLine($"valid: {newPass}");
                        valid++;
                    }
                    else
                    {
                        System.Console.WriteLine($"not valid: {newPass}");
                    }
                    passport = new List<string>();
                }
                i++;
            }
            if(lines[lines.Length - 1].Length > 0)
            {
                string newPass = String.Join(" ", passport.ToArray());
                if(newPass.Contains("byr:") && newPass.Contains("iyr:") && newPass.Contains("eyr:") && newPass.Contains("hgt:") && newPass.Contains("hcl:") && newPass.Contains("ecl:") && newPass.Contains("pid:"))
                {
                    System.Console.WriteLine($"valid: {newPass}");
                    valid++;
                }
                else
                {
                    System.Console.WriteLine($"not valid: {newPass}");
                }
            }
            System.Console.WriteLine($"The number valid is: {valid}");
        }
    }
}

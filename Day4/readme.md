```c#
//used Alex's method. Props to him!!!
using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    string[] InputArray = File.ReadAllLines(@"Input.txt");
    
    Console.WriteLine(part1(InputArray));
    Console.WriteLine(part2(InputArray));
  }

  public static int part1(string[] InputArray){
    int subsets = 0;
    foreach(string line in InputArray){
        string[] pair = line.Split(new char[] {',','-'}, StringSplitOptions.RemoveEmptyEntries);

        int elf1lower=Convert.ToInt32(pair[0]);
        int elf1higher=Convert.ToInt32(pair[1]);
        int elf2lower=Convert.ToInt32(pair[2]);
        int elf2higher=Convert.ToInt32(pair[3]);

        if((elf1lower>=elf2lower&&elf1higher<=elf2higher) || (elf2lower>=elf1lower&&elf2higher<=elf1higher)){
            subsets++;
        }
    }
    return subsets;
  }

    public static int part2(string[] InputArray){
    int subsets=0;
    foreach(string line in InputArray){
        string[] pair = line.Split(new char[] {',','-'}, StringSplitOptions.RemoveEmptyEntries);
        int elf1lower=Convert.ToInt32(pair[0]);
        int elf1higher=Convert.ToInt32(pair[1]);
        int elf2lower=Convert.ToInt32(pair[2]);
        int elf2higher=Convert.ToInt32(pair[3]);

        if((elf1lower >= elf2lower && elf1lower <= elf2higher)||(elf1higher >= elf2lower && elf1higher <= elf2higher)){
            subsets++;
        }
        else if((elf2lower >= elf1lower && elf2lower <=elf1higher)||(elf2higher >= elf1lower && elf2higher <=elf1higher)){
            subsets++;
        }
    }
    return subsets;
  }
}
```

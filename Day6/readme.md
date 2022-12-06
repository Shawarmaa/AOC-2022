```c#
using System;
using System.Linq;

class Program
{
  public static void Main(string[] args)
  {
    part1();
    part2();
  }

  public static void part2(){
    string InputArray = "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg";
    for (int i = 0; i < InputArray.Length - 13; i++)
    {
      string sub = InputArray.Substring(i, 14);
      if (sub.Distinct().Count() == sub.Count())
      {
        Console.WriteLine(i + 14);
        //Console.WriteLine(sub);
        return;
      }
    }
  }
  
  public static void part1(){
    string InputArray = "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg";
    for (int i = 0; i < InputArray.Length - 3; i++)
    {
      string sub = InputArray.Substring(i, 4);
      if (sub.Distinct().Count() == sub.Count())
      {
        Console.WriteLine(i + 4);
        //Console.WriteLine(sub);
        return;
      }
    }
  }  
}
```

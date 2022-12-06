```c#
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
      part1();  
      part2();
        
    }
    public static void part2(){
      Stack<string> s1 = new Stack<string>(new[] { "G", "F", "V", "H", "P", "S" });
      Stack<string> s2 = new Stack<string>(new[] { "G", "J", "F", "B", "V", "D", "Z", "M" });
      Stack<string> s3 = new Stack<string>(new[] { "G", "M", "L", "J", "N" });
      Stack<string> s4 = new Stack<string>(new[] { "N", "G", "Z", "V", "D", "W", "P" });
      Stack<string> s5 = new Stack<string>(new[] { "V", "R", "C", "B" });
      Stack<string> s6 = new Stack<string>(new[] { "V", "R", "S", "M", "P", "W", "L", "Z" });
      Stack<string> s7 = new Stack<string>(new[] { "T", "H", "P" });
      Stack<string> s8 = new Stack<string>(new[] { "Q", "R", "S", "N", "C", "H", "Z", "V" });
      Stack<string> s9 = new Stack<string>(new[] { "F", "L", "G", "P", "V", "Q", "J" });
      Stack<string> flipper = new Stack<string>();

      Dictionary<int, Stack<string>> dic = new Dictionary<int, Stack<string>>();
      dic.Add(1, s1);
      dic.Add(2, s2);
      dic.Add(3, s3);
      dic.Add(4, s4);
      dic.Add(5, s5);
      dic.Add(6, s6);
      dic.Add(7, s7);
      dic.Add(8, s8);
      dic.Add(9, s9);

      string[] InputArray = File.ReadAllLines(@"Input.txt");
      string[] MoveArray = File.ReadAllLines(@"move.txt");
      for(int i=0;i<InputArray.Length;i++)
        {
            string[] command = InputArray[i].Split(" ");//[0]:from,  [1]:to
            int move = Int32.Parse(MoveArray[i]);
            int from_ = Int32.Parse(command[0]);
            int to = Int32.Parse(command[1]);
            string temp1="";
                    
            for(int k=0; k<move;k++){
              temp1= dic[from_].Peek();
              flipper.Push(temp1);
              dic[from_].Pop();
            }
            for(int j=0; j<move;j++){//transer from temp(flipper) stack
              temp1 = flipper.Peek();
              dic[to].Push(temp1);
              flipper.Pop();
            }
            
      
        }
        Console.WriteLine(s1.Peek() + s2.Peek() + s3.Peek() + s4.Peek() + s5.Peek() + s6.Peek() + s7.Peek() + s8.Peek() + s9.Peek());
      
    }

    public static void part1(){
        Stack<string> s1 = new Stack<string>(new[] { "G", "F", "V", "H", "P", "S" });
        Stack<string> s2 = new Stack<string>(new[] { "G", "J", "F", "B", "V", "D", "Z", "M" });
        Stack<string> s3 = new Stack<string>(new[] { "G", "M", "L", "J", "N" });
        Stack<string> s4 = new Stack<string>(new[] { "N", "G", "Z", "V", "D", "W", "P" });
        Stack<string> s5 = new Stack<string>(new[] { "V", "R", "C", "B" });
        Stack<string> s6 = new Stack<string>(new[] { "V", "R", "S", "M", "P", "W", "L", "Z" });
        Stack<string> s7 = new Stack<string>(new[] { "T", "H", "P" });
        Stack<string> s8 = new Stack<string>(new[] { "Q", "R", "S", "N", "C", "H", "Z", "V" });
        Stack<string> s9 = new Stack<string>(new[] { "F", "L", "G", "P", "V", "Q", "J" });

        Dictionary<int, Stack<string>> dic = new Dictionary<int, Stack<string>>();
        dic.Add(1, s1);
        dic.Add(2, s2);
        dic.Add(3, s3);
        dic.Add(4, s4);
        dic.Add(5, s5);
        dic.Add(6, s6);
        dic.Add(7, s7);
        dic.Add(8, s8);
        dic.Add(9, s9);

        string[] InputArray = File.ReadAllLines(@"Input.txt");
        string[] MoveArray = File.ReadAllLines(@"move.txt");

        for(int i=0;i<InputArray.Length;i++)
        {
            string[] command = InputArray[i].Split(" ");//[0]:from,  [1]:to
            int move = Int32.Parse(MoveArray[i]);
            int from_ = Int32.Parse(command[0]);
            int to = Int32.Parse(command[1]);
            string temp1 = "";

            for (int j = 0; j < move; j++)
            {
                temp1 = dic[from_].Peek();
                dic[to].Push(temp1);
                dic[from_].Pop();
            }
        }
        Console.WriteLine(s1.Peek() + s2.Peek() + s3.Peek() + s4.Peek() + s5.Peek() + s6.Peek() + s7.Peek() + s8.Peek() + s9.Peek());
    } 

}
```

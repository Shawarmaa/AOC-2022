```c#
using System;
using System.IO;

class Program {
  public static void Main (string[] args) {
    string[] InputArray = File.ReadAllLines(@"Input.txt");
    int[] arr = new int[InputArray.Length];
    int elf = 0;
    int temp1=0;
    int temp2=0;
    int temp3=0;
    foreach(string line in InputArray)
    {
      if(line != ""){
        arr[elf] = arr[elf]+Convert.ToInt32(line);
      }
      else{
        elf++;
      }
    }
    foreach(int x in arr){
      if(x > temp1){
        temp1 =x;
      }
      if(x<temp1&& x>temp2){
        temp2=x;
      }
      if(x<temp2 && x>temp3){
        temp3=x;
      }
    }
    Console.WriteLine(temp1);
    Console.WriteLine(temp1+temp2+temp3);  
  }
}
```

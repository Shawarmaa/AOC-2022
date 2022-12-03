using System;
class Program {
  public static void Main (string[] args) {
    string[] InputArray = File.ReadAllLines(@"Input.txt");

    string[] letters = {"","a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z","A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
    string[] common = new string[InputArray.Length];

    Console.WriteLine(part1(InputArray,letters,common));
    Console.WriteLine(part2(InputArray,letters,common));
  }

  public static int part1(string[] InputArray, string[] letters, string[] common){
    int score=0;

    foreach(string line in InputArray){
        string one = line.Substring(0, (int)(line.Length / 2));
        string two = line.Substring((int)(line.Length / 2), (int)(line.Length / 2));
        
        int j = 0;
        char temp = ' ';

        foreach(char o in one){
            foreach(char t in two){
                if(temp == o){
                }
                else if(o==t){
                    common[j] = Convert.ToString(o);
                    j++;
                    temp = o;
                }
            }
        }

        foreach(string item in common){
            for(int i =0; i<letters.Length;i++){
                if(item == letters[i]){
                    score+= i;
                }
            }
        }
    }
    return score;
  }

  public static int part2(string[] InputArray, string[] letters, string[]common){
    int score = 0;
    char temp =' ';
    bool nextGroup =false;

    for(int i=0; i<InputArray.Length;i+=3){
        foreach(char c in InputArray[i]){
            foreach(char x in InputArray[i+1]){
                foreach(char y in InputArray[i+2]){
                    if(temp == c && nextGroup==false){
                    }
                    else if(c==x && c==y){
                        common[i] = Convert.ToString(c);
                        temp = c;
                        nextGroup = false;

                    }
                }
            }
        }
        nextGroup=true;
    }

    foreach(string item in common){
        for(int i =0; i<letters.Length;i++){
            if(item == letters[i]){
                score+= i;
            }
        }
    }
    return score;
  }
}
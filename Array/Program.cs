string[] Firstarray=new string[5] {"Love", "25", "13", "mur", "*-*"};
string[] Secondarray= new string[Firstarray.Length];
void Apgrarray(string[] Firstarray, string[]Secondarray)
{
    int current=0;
    for (int i = 0; i < Firstarray.Length; i++)
    {
      if (Firstarray[i].Length<4)
      {
        Secondarray[current]= Firstarray[i];
        current++;
      }  
    }
}
void Showarray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]}"); 
    }
    Console.WriteLine();
}
Apgrarray(Firstarray, Secondarray);
Showarray(Secondarray);

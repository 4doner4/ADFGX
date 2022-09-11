using System.Text;

char[,] alphabet = new char[5,5]
{   {'F', 'N' , 'H' , 'E' , 'Q' },
    {'R', 'D' , 'Z' , 'O' , 'C' },
    {'I', 'S' , 'A' , 'G' , 'U' },
    {'B', 'V' , 'K' , 'P' , 'W' },
    {'X', 'M' , 'Y' , 'T' , 'L' },
};
char[] col = new char[]
{
    'A', 'D' , 'F' , 'G' , 'X'
};
char[] row = new char[]
{
    'A', 'D' , 'F' , 'G' , 'X'
};

string a = "asdasdasdasdasda";
String key = "BAtTLE";


a = a.ToUpper();
char[] arr = a.ToCharArray();
string[] step1 = new string[a.Length];
string tmp = "";


char[] keyarr = key.ToCharArray();
     

for (int k = 0; k < a.Length; k++)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if(arr[k] == alphabet[i, j])
            {
                step1[k] = $"{col[i]}{row[j]}";
            }
        }
    }
}


for (int i = 0; i < step1.Length; i++)
{
    Console.WriteLine(step1[i]);
    tmp += step1[i];
}
Console.WriteLine("\nstep2: ");


for (int i = 0; i < tmp.Length; i++)
{
    arr = tmp.ToCharArray();
    Console.Write($"{arr[i]}");
}


string[] table = new string[key.Length];
for (int i = 0; i < key.Length; i++)
{
    for (int z = i; z < arr.Length; z += key.Length)
    {
        table[i] += arr[z].ToString();
    }
}


Console.WriteLine();
for (int i = 0; i < table.Length; i++)
{
    Console.WriteLine(table[i]);
}


key = String.Concat(key.OrderBy(key => key));
string res = "";
List<int> indexes = new List<int>();


for (int i = 0; i < keyarr.Length; i++)
{
    for (int j = 0; j < keyarr.Length; j++)
    {
        if (key[j] == keyarr[i])
        {
            indexes.Add(j);
            break;
        }
        
    }
}


foreach(int i in indexes)
{
    res += table[i]; 
}
Console.WriteLine(res);

Console.WriteLine("Enter the first id number");
int ids =int.Parse( Console.ReadLine());
int totalValid = 0;

for (int i = 1; i < 9; i++)
    
{
    Console.WriteLine($"Enter the {i} id number");
    
        int id = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        if (id * 2 > 10)
            { 
            totalValid += (id * 2/10) + (id*2%10);
            continue;  
        }
        totalValid +=  (id*2);
    }
    else{
        totalValid += id;
    }
    
}

if ((10 - (totalValid % 10) + totalValid) - totalValid == ids)
{
    Console.WriteLine("good");
}
else { Console.WriteLine("bad"); }

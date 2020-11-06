using System;
class IndexerCreation  
{
    private string[] val = new string[4];
    public string this[int index]  
    {
        get
        {
            return val[index]; 
        }
        set
        {
            val[index] = value; 
        } 
    } 
} 
 
class MyClass { 
    
    public static void Main() {
        IndexerCreation ic = new IndexerCreation();
        ic[0] = "Abhijeet"; 
        ic[1] = "Aman"; 
        ic[2] = "Amit";
        ic[3] = "Aniket";
  
        Console.Write("Printing values stored in objects used as arrays\n");
        Console.WriteLine(ic[0]+"\n"+ic[1]+"\n"+ic[2]+"\n"+ic[3]);

    } 
}

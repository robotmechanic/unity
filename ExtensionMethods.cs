static class ExtensionMethods 
{

 //A simple but nifty example of how to add methods to objects without inheritance
 public static void Shuffle(this IList list)  
 {  
     var rand = new System.Random();
     int n = list.Count;  
     while (n > 1) 
     {  
         n--;  
         int k = rand.Next(n + 1);  
         T value = list[k];  
         list[k] = list[n];  
         list[n] = value;  
     }  
 }

}
//ARRAYS C#

public class Program
{
    public static void Main(string[] args)
    {
        string[] myFirstArray = new string[5]; //declaration of an array with 5 elements
        myFirstArray[0] = "Apple";
        myFirstArray[1] = "Banana";
        myFirstArray[2] = "Cherry";
        myFirstArray[3] = "Date";
        myFirstArray[4] = "Elderberry";

        Console.WriteLine($"My first array elements are: {string.Join(", ", myFirstArray)}");
        Console.WriteLine();

        //Remove an element from the array (e.g., remove "Cherry")
        //To Remove an element, we can copy all elements except the one we want to remove into a new array
        string[] newArray = new string[myFirstArray.Length - 1]; //Because we are removing one element
        Array.Copy(myFirstArray,0,newArray,0,2); //Copy first two elements
        Array.Copy(myFirstArray,3,newArray,2,2); //Copy last two elements
        Console.WriteLine($"My new array elements after removing an element: {string.Join(", ", newArray)}");

        Console.WriteLine();
        Console.WriteLine($"First element of the array: {newArray[0]}");
        Console.WriteLine($"Last element of the array: {newArray[^1]}"); //Using ^1 to access the last element
    
        Console.WriteLine();
        Console.WriteLine($"Middle element of the array: {string.Join(", ", newArray[1..4])}"); //Using range operator to access middle elements
    
    
    }
}
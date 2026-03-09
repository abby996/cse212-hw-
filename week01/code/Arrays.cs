public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

         
      // Plan

        // Step 1: Create a new array of type double with the size equal to length.
        // Step 2: Use a loop that starts at index 0 and continues until length - 1.
        // Step 3: For each position in the array, calculate the multiple of the number.
        // Step 4: The first value should be number * 1, the second number * 2, etc.
        // Step 5: Store the calculated value into the array at the current index.
        // Step 6: After the loop finishes, return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)

        {
           
           multiples[i] = number * (i + 1);
        }
        
        return multiples; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.




       // PLAN
        // Step 1: Determine how many times the list needs to rotate (amount).
        // Step 2: Repeat the rotation process 'amount' times using a loop.
        // Step 3: Each rotation takes the last element of the list.
        // Step 4: Store that last value in a temporary variable.
        // Step 5: Remove the last element from the list.
        // Step 6: Insert the stored value at the beginning of the list (index 0).
        // Step 7: After repeating this process amount times, the list will be rotated correctly.



       
        int count =data.Count;

        for (int i = 0 ; i < amount; i++)
        {
           
            int lastElement = data[count - 1];
            data.RemoveAt(count - 1);

        
            data.Insert(0, lastElement);
        }

    }
}

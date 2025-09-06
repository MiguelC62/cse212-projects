using System.ComponentModel;

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
        // 1. Check if length is less than or equal to 0. If so, return an empty array
        // 2. Create a double array with size length to store the multiples.
        // 3. Traverse i indices from 0 to length-1
        //    - For each i calculate the multiple and store the result.
        // 4. When the loop ends, return the result of the array with all the multiples.

        if (length <= 0)
        {
            // if length is not positive return an empty array
            return new double[0];
        }
        var result = new double[length];
        for (int i = 0; i < length; i++)
        {
            // i go from 0 to length-1, because of this used (i+1)
            result[i] = number*(i+1);
        }

        return result; // replace this return statement with your own
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
        //1. Validate input parameters:
        //   - if the data list is empty or amount is 0 return the list as is
        //2. Determine the new starting position:
        //   - To rotate right, the last amount elements will move to the top
        //3. Create a new list (or mify the existing one):
        //   - Take the last amount elements from the original list and add them to the reult list.
        //   - Then add the first (data.Count - amount) elements to the end of the result list.
        //4. Return the rotated list.

        //parameters validated
        if (data == null || data.Count == 0 || amount <= 0)
            return;

        int n = data.Count;
        amount = amount % n; // in case amount >= n

        if (amount == 0) // no need rotation
            return ;

        //Save the last amount elements
        var tail = data.GetRange(n - amount, amount);

        //Save the first n-amount elements
        var head = data.GetRange(0,n - amount);

        //Clean the original list
        data.Clear();

        //add the last element
        data.AddRange(tail);

        //Add the first elements
        data.AddRange(head);

    }
}

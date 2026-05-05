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

        var results = new double[length];

        for(var i = 0; i < length;i++){
            results[i] = number * (i + 1) ;
        }

        return results; // replace this return statement with your own
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

        // create an array to hold the correct values and location
        var results = new int[data.Count];

        // Iterate through data object
        for(var i = 0; i< data.Count ;i++){

            // Define new index by reaching back the change amount
            var new_index = i - amount;

            if(new_index < 0 ){
                // If the new index is negative, we need to grab values from the end of the array
                // So we get the lengh of data obj and suctract by negative number to find our
                // new index
                results[i] = data[data.Count + new_index];
            }else{
                // if we are not negative, we can safely reach to the left and pull that value forward 
                // to the right.
                results[i] = data[new_index];
            }
        }
        // Now we just copy our values back over the original data obj
        for(var i = 0;i < data.Count; i++){
            data[i] = results[i];
        }
    }
}

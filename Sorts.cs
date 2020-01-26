using System;

public static class Sorts{

    #region RadixSort
    public static int[] RadixSort(int[] input){

        int mx = 0; // Biggest number
        int e  = 0; // Amount of right shift

        int[] output = new int[input.Length];

        // Copying numbers from the input to the output
        for (int i = 0; i < output.Length; i++)
            output[i] = input[i];
        
        // Finding biggest number from the input
        mx = input[0];
        for (int i = 1; i < input.Length; i++)
            if(mx < input[i]) mx = input[i];

        while (mx > 0)
        {
            // Sorting the output and shift by e bits
            output = Radix(output, e);
            // shift the biggest number by 8
            mx = mx >> 8;
            e+=8;
        }

        return output;
    }

    private static int[] Radix(int[] input, int e){
        int[] output = new int[input.Length];
        int[] dist   = new int[0x100];
        int[] ind    = new int[0x100];

        // Fill tha array dist by numbers from input
        for (int i = 0; i < input.Length; i++)
            dist[(input[i] >> e) & 0xFF ] = dist[(input[i] >> e) & 0xFF]+1;

        ind[0] = 0;

        // Set indexes by numbers from the dist
        for (int i = 1; i < 0x100; i++)
        {
            ind[i] = ind[i-1]+dist[i-1];
        }

        // Fill the output
        for (int i = 0; i < input.Length; i++){
            output[ ind[(input[i] >> e) & 0xFF] ] = input[i];
            ind[(input[i] >> e) & 0xFF] = ind[(input[i] >> e) & 0xFF]+1;
        }

        return output;
    }
    #endregion

    #region BubbleSort
    public static int[] BubbleSort(int[] input){
        int n = 0; // Number for swapping
        int[] output = new int[input.Length];
        for (int i = 0; i < output.Length; i++)
            output[i] = input[i];

        for (int i = 0; i < output.Length-1; i++)
        {
            for (int j = 0; j < output.Length-i-1; j++)
            {
                if(output[j] > output[j+1]){
                    n           = output[j];
                    output[j]   = output[j+1];
                    output[j+1] = n;
                }
            }
        }

        return output;
    } 
    #endregion
}

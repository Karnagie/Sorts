using System;

public static class Sorts{

    #region RadixSort
    public static int[] RadixSort(int[] input){
        int mx = 0;
        int e = 0;
        int[] output = new int[input.Length];
        for (int i = 0; i < output.Length; i++)
            output[i] = input[i];
        

        mx = input[0];
        for (int i = 1; i < input.Length; i++)
            if(mx < input[i]) mx = input[i];

        while (mx > 0)
        {
            output = Radix(output, e);
            mx = mx >> 8;
            e+=8;
        }

        return output;
    }

    private static int[] Radix(int[] input, int e){
        int[] output = new int[input.Length];
        int[] dist = new int[0x100];
        int[] ind = new int[0x100];

        for (int i = 0; i < 0x100; i++)
        {
            dist[i] = 0;
        }

        for (int i = 0; i < input.Length; i++)
            dist[(input[i] >> e) & 0xFF ] = dist[(input[i] >> e) & 0xFF]+1;

        ind[0] = 0;

        for (int i = 1; i < 0x100; i++)
        {
            ind[i] = ind[i-1]+dist[i-1];
        }

        for (int i = 0; i < input.Length; i++){
            output[ ind[(input[i] >> e) & 0xFF] ] = input[i];
            ind[(input[i] >> e) & 0xFF] = ind[(input[i] >> e) & 0xFF]+1;
        }

        return output;
    }
    #endregion

    #region BubbleSort
    //public static int[] BubbleSort(int[] input){
        //int[] output = new

    //} 
    #endregion
}
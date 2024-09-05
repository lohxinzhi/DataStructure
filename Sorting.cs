using System.Runtime.CompilerServices;

namespace DataStructure
{
    class Sorting
    {
        static public void QuickSort(int[] array){
            static void helper(int[] array, int start, int end){
                var rnd = new Random();
                int rnd_int = rnd.Next(start, end+1);
                (array[end], array[rnd_int]) = (array[rnd_int],array[end]);
                int pivot = array[end];
                int swap = start;
                for (int i = start; i<=end; i++){
                    if (array[i] <= pivot){
                        (array[i],array[swap])=(array[swap],array[i]);
                        swap++;
                    }
                }
                if (swap-2>start){
                    helper(array, start, swap-2);
                }
                if (swap<end){
                    helper(array, swap, end);
                }
            }
            helper(array, 0, array.Length-1);
        }

        static public void MergeSort(int[] array){
            static void helper(int[] array){

                if (array.Length == 1){
                    return;
                }

                int[] right_sub = new int[array.Length/2];
                int[] left_sub = new int[array.Length-array.Length/2];
                for (int i = 0; i < left_sub.Length; i++){
                    left_sub[i] = array[i];
                }
                for(int i = 0; i<right_sub.Length; i++){
                    right_sub[i] = array[left_sub.Length+i];
                }
                helper(left_sub);
                helper(right_sub);
                int j = 0;
                int k = 0;
                for(int i = 0; i<array.Length; i++){
                    if (k>=right_sub.Length){
                        array[i] = left_sub[j++];
                    }
                    else if (j>=left_sub.Length){
                        array[i] = right_sub[k++];
                    }
                    else if(left_sub[j]<=right_sub[k]){
                        array[i] = left_sub[j++];
                    }
                    else{
                        array[i] = right_sub[k++];
                    }
                }
                return;
            }

            helper(array);
        }
    }
}
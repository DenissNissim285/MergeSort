using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;   
  
namespace MergeSort    
{    
   public class MergeSort    
    {    
	/*
	Merge sort is a sorting algorithm that divides the array into two parts and continues until each part contains one element.
	This process continues until the array is sorted.
    A recursive algorithm where an array of size N is divided into a maximum of logN parts, and the merging of all subsets into a single array takes O(N) time.
    Therefore the time complexity of the merge sort is O(nlogn).	
	*/
        static public void MainMerge(int[] array, int left, int mid, int right)    
        {  
		//merge function performs sort and merge 
            int[] temp = new int[25];    
            int i, eol, num, pos;    
            eol = (mid - 1);    
            pos = left;   
            num = (right - left + 1);   
  
            while ((left <= eol) && (mid <= right))    
            {    
                if (array[left] <= array[mid])    
                    temp[pos++] = array[left++];    
                else    
                    temp[pos++] = array[mid++];    
            }    
            while (left <= eol)    
                temp[pos++] = array[left++];    
            while (mid <= right)    
                temp[pos++] = array[mid++];   
            for (i = 0; i < num; i++)    
            {    
                array[right] = temp[right];    
                right--;    
            }    
        }   
  
        static public void SortMerge(int[] array, int left, int right)    
        {    
		//recursive function function for mergeSort that splits the array 
            int mid;    
            if (right > left)    
            {    
                mid = (right + left) / 2;    
                SortMerge(array, left, mid);    
                SortMerge(array, (mid + 1), right);    
                MainMerge(array, left, (mid + 1), right);  //Calling the merge function
            }    
        }     
	   static public void Main(string[] args) {
		 // An example of an array before and after sorting  
         int[] arr = {3, 75, 45, 8, 34, 88,90, 23, 67, 12};
         int n = 10, i;
         Console.WriteLine("***Demo of Merge Sort***");
         Console.Write("The array is: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
         SortMerge(arr, 0, n-1);
         Console.Write("\nAfter sorted: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
	   }
   }
}

      
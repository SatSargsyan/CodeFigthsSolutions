# CodeFigthsSolutions

```C#
int[] removeArrayPart(int[] inputArray, int l, int r) {
   if(inputArray.Length == 0) return inputArray;
return inputArray.Where((x,i)=>i<l||i>r).ToArray();
}
```
```C#
int[] replaceMiddle(int[] arr) {
int[] arr1 = new int[arr.Length-1];
        if(arr.Length%2 == 0)
               {
    for(int i =0; i< arr1.Length; i++)
    {
        if(i < arr.Length/2-1)
        {
                arr1[i] = arr[i];
        }
                    
        arr1[arr.Length/2-1] = arr[arr.Length/2 -1] + arr[arr.Length/2];
        
        if(i > arr.Length/2-1)
        {
                arr1[i] = arr[i+1]; 
        }
           
    }
  
 return arr1;
               }  else return arr;
}
```


```C#
int[] replaceMiddle(int[] arr) {
int n=arr.Length/2;
int[] arr1 = new int[n];
        int[] arr2 = new int[n-1];
        if(arr.Length%2 == 0)
               {
    for(int i =0; i< arr1.Length; i++)
    {
            arr1=arr.where((x,t)=>t<n-1).ToArray();
                            
        arr1[arr.Length/2-1] = arr[arr.Length/2 -1] + arr[arr.Length/2];
        
        arr2=arr.where((x,k)=>k>n/2).ToArray();
    }
  
 return arr1.Union(arr2).ToArray();
               }  else return arr;
}

```


```C#
int[] replaceMiddle(int[] arr) {
int n=arr.Length;
        if(arr.Length%2 == 0)
              
               return (arr.where((x,t)=>t<n-1).ToArray()).Concat(new [] { arr.Skip(arr.Length/2-1).Take(2).Sum() }).Concat(arr.where((x,k)=>k>n/2).ToArray());
                            
         else return arr;
}
```

```C#
int[] replaceMiddle(int[] arr) {
    return arr.Length % 2 == 1 ? arr :
        arr.Take(arr.Length/2-1)
            .Concat(new [] { arr.Skip(arr.Length/2-1).Take(2).Sum() })
            .Concat(arr.Skip(arr.Length/2+1))
            .ToArray();
}

```



#### Given K sorted arrays, return their sorted concatenation.

Example

For arrays = [[1, 3, 5], [2, 3], [2, 3, 5, 8]], the output should be
mergeKArrays(arrays) = [1, 2, 2, 3, 3, 3, 5, 5, 8].

Input/Output

[time limit] 6000ms (cs)
[input] array.array.integer arrays

An array of K one-dimensional sorted arrays.

Constraints:
3 ≤ arrays.length ≤ 10,
0 ≤ arrays[i].length ≤ 5,
-100 ≤ arrays[i][j] ≤ 100.
```C#
int[] mergeKArrays(int[][] arrays) {
       
            int    slength=0;
         for (int i = 0; i < arrays.Length; i++)
        {
           slength+= arrays[i].Length; 
        }
               
         int[] arr1=new int[slength];
        int k=0;
        while(k<slength)
        {
for (int i = 0; i < arrays.Length; i++)
        {
                for (int j = 0; j < arrays[i].Length; j++)
            {
          
           arr1[k]=arrays[i][j];
                   k++; 
            
        }    
        }
        }    

        Array.Sort(arr1);
  return arr1;
}
```

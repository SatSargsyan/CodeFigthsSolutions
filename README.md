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


#### In order to stop the Mad Coder evil genius you need to decipher the encrypted message he sent to his minions. The message contains several numbers that, when typed into a supercomputer, will launch a missile into the sky blocking out the sun, and making all the people on Earth grumpy and sad.

You figured out that some numbers have a modified single digit in their binary representation. More specifically, in the given number n the kth bit from the right was initially set to 0, but its current value might be different. It's now up to you to write a function that will change the kth bit of n back to 0.

<a href=https://codefightssolver.wordpress.com/2016/10/19/kill-k-th-bit/>Example</a>

For n = 37 and k = 3, the output should be
killKthBit(n, k) = 33.

3710 = 1001012 ~> 1000012 = 3310.

For n = 37 and k = 4, the output should be
killKthBit(n, k) = 37.

The 4th bit is 0 already (looks like the Mad Coder forgot to encrypt this number), so the answer is still 37.


```C#
int killKthBit(int n, int k)
{
            returnn & ~(1 << (k - 1)) ;
          
}
```

#### You are given an array of up to four non-negative integers, each less than 256.

Your task is to pack these integers into one number M in the following way:

The first element of the array occupies the first 8 bits of M;
The second element occupies next 8 bits, and so on.
Return the obtained integer M.

Note: the phrase "first bits of M" refers to the least significant bits of M - the right-most bits of an integer. For further clarification see the following example.

Example

For a = [24, 85, 0], the output should be
arrayPacking(a) = 21784.

An array [24, 85, 0] looks like [00011000, 01010101, 00000000] in binary.
After packing these into one number we get 00000000 01010101 00011000 (spaces are placed for convenience), which equals to 21784.

```C#
int arrayPacking(int[] a) {
 if(1 <= a.Length && a.Length <= 4) {
        int result = 0;
        for(int index=0;index<a.Length;index++) {
            if(a[index]>256 || a[index]<0) {
                throw new ArgumentOutOfRangeException();
            }
            else {
                result += a[index] << 8 * index;
            }
        }
        return result;
    }
    else {
        throw new ArgumentOutOfRangeException();
    }
         }
```
#### You are given two numbers a and b where 0 ≤ a ≤ b. Imagine you construct an array of all the integers from a to b inclusive. You need to count the number of 1s in the binary representations of all the numbers in the array.

Example

For a = 2 and b = 7, the output should be
rangeBitCount(a, b) = 11.

Given a = 2 and b = 7 the array is: [2, 3, 4, 5, 6, 7]. Converting the numbers to binary, we get [10, 11, 100, 101, 110, 111], which contains 1 + 2 + 1 + 2 + 2 + 3 = 11 1s.
```C#
int rangeBitCount(int a, int b) {
    if(0<=a && a<=b) {
        int total = 0;
        for (int i = a; i <= b; i++) {
            int t = i;
            while (t != 0) {
                if((t&1)==1)
                total++;
                t >>= 1;
            }
        }
        
 
        return total;
    }
    else
    {
        throw new ArgumentOutOfRangeException();
    }
}
```
#### Reverse the order of the bits in a given integer.

Example

For a = 97, the output should be
mirrorBits(a) = 67.

97 equals to 1100001 in binary, which is 1000011 after mirroring, and that is 67 in base 10.

For a = 8, the output should be
mirrorBits(a) = 1.
```C#
int mirrorBits(int a) {
    int b = 0;
    while (a > 0) {
        b <<= 1;
        b |= a & 1;
        a >>= 1;
    }

    return b;
}
```

#### Presented with the integer n, find the 0-based position of the second rightmost zero bit in its binary representation (it is guaranteed that such a bit exists), counting from right to left.

Return the value of 2position_of_the_found_bit.

Example

For n = 37, the output should be
secondRightmostZeroBit(n) = 8.

3710 = 1001012. The second rightmost zero bit is at position 3 (0-based) from the right in the binary representation of n.
Thus, the answer is 23 = 8.

```C#
int secondRightmostZeroBit(int n)
{
  return  -~((n-~(n^(n+1))/2)^(n-~(n^(n+1))/2+1))/2 ; ;
}
```

#### You're given an arbitrary 32-bit integer n. Swap each pair of adjacent bits in its binary representation and return the result as a decimal number.

Example

For n = 13, the output should be
swapAdjacentBits(n) = 14.

1310 = 11012 ~> 11102 = 1410.

For n = 74, the output should be
swapAdjacentBits(n) = 133.

7410 = 010010102 ~> 100001012 = 13310.
Note the preceding zero written in front of the initial number: since both numbers are 32-bit integers, they have 32 bits in their binary representation. The preceding zeros in other cases don't matter, so they are omitted. Here, however, it does make a difference.
```C#
int swapAdjacentBits(int n)
{
  return n==0 ? 0
          : n % 4 == 0 ? 4*swapAdjacentBits(n/4)
              : n %4 == 1 ? 4*swapAdjacentBits(n/4) + 2
                  : n %4 == 2 ? 4*swapAdjacentBits(n/4) + 1
                      : 4*swapAdjacentBits(n/4) + 3;
}
```
```C#
int swapAdjacentBits(int n)
{
  return  (int)(((n & 0xAAAAAAAA) >> 1) | ((n & 0x55555555) << 1));
}
```


#### You're given two integers, n and m. Find position of the rightmost bit in which they differ in their binary representations (it is guaranteed that such a bit exists), counting from right to left.

Return the value of 2position_of_the_found_bit (0-based).

Example

For n = 11 and m = 13, the output should be
differentRightmostBit(n, m) = 2.

1110 = 10112, 1310 = 11012, the rightmost bit in which they differ is the bit at position 1 (0-based) from the right in the binary representations.
So the answer is 21 = 2.

For n = 7 and m = 23, the output should be
differentRightmostBit(n, m) = 16.

710 = 1112, 2310 = 101112, i.e.

00111
10111
So the answer is 24 = 16.

```C#
int differentRightmostBit(int n, int m){
    return -~((~(n^m))^((~(n^m))+1))/2 ;
}
```
#### You're given two integers, n and m. Find position of the rightmost pair of equal bits in their binary representations (it is guaranteed that such a pair exists), counting from right to left.

Return the value of 2position_of_the_found_pair (0-based).

Example

For n = 10 and m = 11, the output should be
equalPairOfBits(n, m) = 2.

1010 = 10102, 1110 = 10112, the position of the rightmost pair of equal bits is the bit at position 1 (0-based) from the right in the binary representations.
So the answer is 21 = 2.
```c#
int equalPairOfBits(int n, int m)
{
  return ~(n^m) & -~(n ^ m) ;
}
```


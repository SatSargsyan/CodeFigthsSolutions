# CodeFigthsSolutions

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

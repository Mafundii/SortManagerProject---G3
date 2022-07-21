# MVC SortManagerProject
This is the documentaton that will explain how to use this MVC SortManager, while also explaining the sorting algorithms that this program (and Microsoft's .NET Sort) will use to complete the job. The documentation will be split into two main sections. Section 1 will outline how to use the application, and Section 2 will explain the algorithms.

## How to use this programme
<img src="https://user-images.githubusercontent.com/91839242/180285102-3c45756f-890b-46ff-8906-10d8e9044396.png" alt="meus" width='600'/>

This section will explain how to use the Input/Output System of the Sorting program:

### Main Menu
<img src="https://user-images.githubusercontent.com/91839242/180285324-753cf5de-5d17-4f7c-bbfd-7f4688203093.png" alt="meus" width='600'/>

This segment allows you to choose from the corresponding list of options 1 - 4. If the user types 4, the program will finish executing, if the user types a value between 1 - 3 inclusive, the progam will pick the corresponding algorithm. 


### Size of the List
<img src="https://user-images.githubusercontent.com/91839242/180285500-919300b7-6b52-431f-a3e5-519eeccf0f02.png" alt="meus" width='500'/>

The second segment will allow the user to specify the size of the array, between zero and twenty (inclusive). TThe user will be prompted that their value is too low or high, before being sent back to the menu.


### How the program will work
<img src="https://user-images.githubusercontent.com/91839242/180285626-e4248e1d-f448-4656-9577-4483224da4fb.png" alt="meus" width='600'/>

After both inputs have been typed, the array will be filled with randomly generated numbers. After that, the array will then be outputted to the user, and the array will be sent to the appropriate class & method, and the list will be sorted accordingly.


One particular feature will show how long the search has taken to be completed. This is useful for those who wish to compare the speeds of certain searching algorithm.

The important thing to note is that the order will always be ASCENDING and the array will always have RANDOMLY GENERATED values. 

### Exit Program
<img src="https://user-images.githubusercontent.com/91839242/180285731-bf8c840f-9816-4475-9104-640fe75a6f17.png" alt="meus" width='600'/>

If the user wishes to leave the program, they simply opt for option four, which will result in the program finishing.


## The algorithms
This section outlines all the algorithms implemented by us (Bubble Sort and Merge Sort) as well as those implemented by Microsoft's List.Sort method.

### Bubble Sort
Bubble Sort is a simple searching algorithm, that involves iteratively swapping around values in an array so that the adjacent numbers are in the correct order. For example, when sorting in ascending order, if a 7 is followed by a 3, these two numbers are swapped. Bubble sort then compares that 7 with the follwoing adjacent value. Then the bubble sorting algorithm will continue swapping values iteratively until complete. An example diagam shows the abridged process:

<img src="https://techdemic.com/wp-content/uploads/2017/08/BubbleSort.jpg" alt="Bubble Sorter" width='600'/>

Image credit: Techdemic

Our program will carry out an ascending bubble sort, with an array of random values, the length being specified by the end user. The bubble sort will examine each pair in the array, iterating for the amount of pairs in the array. Once the sort has been completed, the array is returned to the controller. If an empty array is passed, an empty array is returned, and singular value arrays will just simply return that value without entering the two loops.

### Merge Sort
Merge sort is a more complex searching algorithm. This algorithm involves splitting the main array into left and right sub-arrays, either of equal size or with one being 1 space longer (in the case of an odd array). This runs recursively until each array has one value. Each value is then compared with each other before being combined together. Merge Sort is more space complex, due to the need of the extra lists required, however it would be quicker than Bubble Sort. The end result is a sorted list, and this can either be done in ascending or descending order. A diagram outlined below shows the process:

<img src="https://dotnettutorials.net/wp-content/uploads/2019/09/c-users-pranaya-pictures-merge-sort-in-c-png.png" alt="Marge Sorter" width='500'/>

Image Credit: DotNetTutorials

Our program will carry out an ascending merge sort, with an array of random values - the length being specified by the end user. The merge sort will recursively divide the elements before sorting and combining them together. Once the sort has been completed, the array is returned to the controller. If an empty array is passed, an empty array is returned, and singular value arrays will just simply return that value.

### .NET Sort
The .NET (sometimes referred to as DOTNET) Sort will simply call the Sort library method from .NET library before returning the result. The algorithm that the Lits.Sort() method uses differs depending on how long the list is, to ensure that the most efficient algorithm is being selected! According to Microsoft:

|Partition Size|SortMethod|Diagram|Image Credit|
|-|-|-|-|
| <= 16 | Insertion Sort | <img src="https://media.geeksforgeeks.org/wp-content/uploads/insertionsort.png" alt="Insertion Sorter" width='300'/>  | Geeks for Geeks |
| > 2log(n) | Heapsort | <img src="https://www.fatalerrors.org/images/blog/a0e2fecd2dc07398a4882684790b9126.jpg" alt="Heap Sorter" width='300'/>  | FatalErrors (blog) |
| < 16 && > 2log(n) | Quick Sort | <img src="https://res.cloudinary.com/nlogn/image/upload/f_auto,q_auto/v1588661780/quick-sort-1.png" alt="Marge Sorter" width='300'/> | Nlogn |


The .NET Sort method is designed for lists, so the Array is converted to a list when in the class that calls the Sort() method, and then the sorted list is converted into an array before being returned to the program.

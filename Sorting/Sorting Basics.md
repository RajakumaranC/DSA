# Sorting Algorithm Basics

## 1. Selection Sort

    The array is split to sorted and unsorted list with no elements considerd in sorted list at starting.
     
    Keep a pointer at start of the List and at every iteration pick the smallest or largest element replace with value at the pointer location and move the pointer forwards.
    Once the pointer reaches end You know you are done.

    Time Complexity: O(n*n) --> for best and worst 
    Reason: We iterate through two array irrespective of size of array and the order of element before sorting.

    Space Complexity: O(1) --> not using any additional space, sorting the elements in place.



## 2. Insertion Sort

    Simlar to Selection sort: Difference is instead of selecting smallest elemet in remainder array each time, we are inserting the current element in the sorted portion at the right spot at that iteration.

    The array is split into sorted and unsorted array. the first element is considerd in the sorted portion

    at each iteration, the current element in unsorted array, is chekced if smaller than last element in the sorted list, 

        if yes --> keep going backwards in sorted array, and keep swapping the elements until you find the right spot for the element in sorted array at that iteration. 

        if no --> go to next iteration

    Time Complexity: O(n*n) --> for best and worst 
    Reason: We iterate through two array irrespective of size of array and the order of element before sorting.

    Space Complexity: O(1) --> not using any additional space, sorting the elements in place.

## 3. Bubble Sort

    this the worst so far of every sorting algorithm. In this, we compare each element to the next element and swap if its not in the right order.



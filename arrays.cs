using System;

int[] numbers = {1, 2, 3, 4, 5}; 


int[] myArray = new int[5]; 


int[] myArray = new int[3];


myArray[0] = 10; // Assigns 10 to the first position 
myArray[1] = 20; // Assigns 20 to the second position 
myArray[2] = 30; // Assigns 30 to the third position


Console.WriteLine(myArray[1]); // Prints 20


int[] numbers = {10, 20, 30, 40, 50}; 
for (int i = 0; i < numbers.Length; i++) // Length gives the size of the array 
{ 
    Console.WriteLine(numbers[i]); // Access each element using its index 
}


 int[] numbers = {10, 20, 30, 40, 50}; 
int sum = 0; 
for (int i = 0; i < numbers.Length; i++) 
{ 
    sum += numbers[i]; // Add each element to the sum 
} 
Console.WriteLine("Total sum: " + sum); // Prints the total sum


 int[,] matrix = new int[2, 3];

 
 matrix[0, 0] = 1; // First row, first column 
matrix[0, 1] = 2; // First row, second column 
matrix[1, 2] = 3; // Second row, third column


Console.WriteLine(matrix[1, 2]); // Prints 3


int[,] matrix = { {1, 2, 3}, {4, 5, 6} }; 
for (int i = 0; i < 2; i++) // Loop through rows 
{ 
for (int j = 0; j < 3; j++) // Loop through columns 
    { 
        Console.Write(matrix[i, j] + " "); // Access each element 
    } 
    Console.WriteLine(); // New line after each row 
}
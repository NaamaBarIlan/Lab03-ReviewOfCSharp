## Review of C#

Lab: 03 - Review of C#

*Author: Na'ama Bar-Ilan*

----

## Description

This series of challenges is designed to evaluate the overall comfort level with C#.

## Challenges

1. Challenge 1
2. Challenge 2
3. Challenge 3
4. Challenge 4
5. Challenge 5
6. Challenge 6
7. Challenge 7
8. Challenge 8 
9. Challenge 9

---

### Getting Started
Clone this repository to your local machine.

```
$ git clone [repo clone url here]
```

### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```Lab03-ReviewOfCSharp``` directory.

Then select and open ```Lab03-ReviewOfCSharp.sln```

---

### Challenge 1

#### Problem Domain
Write a program that asks the user for 3 numbers. 

Return the product of these 3 numbers multiplied together. 

If the user puts in less than 3 numbers, return 0; 

If the user puts in more than 3 numbers, only multiply the first 3. 

If the number is not a number, default that value to 1.

Example:
```
Please enter 3 numbers: 4 8 15
The product of these 3 numbers is: 480
```

Tests: 
1. Input a string of numbers and it returns a product of all numbers 
2. Input more than 3 numbers 
3. Input of less than 3 numbers 
4. Can it handle negative numbers

---

### Challenge 2

#### Problem Domain

Create a method that asks the user to enter a number between 2-10. Then, prompt the user that number of times for random numbers.

After the user has inputted all of the numbers. Find the average of all the numbers inputted.

Specs: 
1. Do not let the user put in negative numbers 
2. Confirm each input is a real number

Example:
```
Please enter a number between 2-10: 4

1 of 4 - Enter a number: 4
2 of 4 - Enter a number: 8
3 of 4 - Enter a number: 15
4 of 4 - Enter a number: 16
```

The average of these 4 numbers is: 10

Tests: 
1. Input different ranges of numbers and confirm averages 
2. Confirm input 
3. All numbers are 0s

### Challenge 3

#### Problem Domain

Create a method that will output to the console the following design. Pay attention to spacing.

```
    * 
   *** 
  *****
 *******
*********
 *******
  *****
   ***
    * 
```

Tests:

No tests are required

### Challenge 4

#### Problem Domain
Write a method that brings in an integer array and returns the number that appears the most times. 

If there are no duplicates, return the first number in the array. 

If more than one number show up the same amount of time, return the first found.

Example: 
```
Input: [1,1,2,2,3,3,3,1,1,5,5,6,7,8,2,1,1]
output: 1
```
Tests:

1. Input different size arrays
2. All numbers in the array are the same value
3. No duplicates exist in the array
4. There multiple numbers that show up the same amount of times.

### Challenge 5

#### Problem Domain

Write a method in that finds the maximum value in the array. The array is not sorted. You may not use .Sort()

Example: 
```
input [5, 25, 99, 123, 78, 96, 555, 108, 4]
return: 555
```

Tests: 
1. Negative numbers 
2. All values are the same

### Challenge 6

#### Problem Domain

Write a method that asks the user to input a word, and then saves that word into an external file named words.txt

Tests are optional for this challenge

### Challenge 7

#### Problem Domain

Write a method that reads the file in from Challenge 6, and outputs the contents to the console.

Tests are optional for this challenge

### Challenge 8

#### Problem Domain

Write a method that reads in the file from Challenge 6. Removes one of the words, and rewrites it back to the file.

Tests are optional for this challenge

### Challenge 9

#### Problem Domain

Write a method that asks the user to input a sentence and returns an array that with the word and the number of characters each word has:

```
Example: input: "This is a sentence about important things"
Output: ["this: 4","is: 2", "a: 1", "sentence: 8", "about: 5", "important: 9", "things: 6"]
```

Tests: 
1. Input a sentence, and it returns the correct array 
2. Input a sentence and confirm it returns an array 
3. Use different sentences with different symbols

### Visuals

#### Image Description
![Image 1](img/)

#### Image Description
![Image 2](img/)

#### Image Description
![Image 3](img/)

---

### Change Log
 

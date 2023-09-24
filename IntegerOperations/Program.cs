//Create a program that receives four integer numbers.

//You should perform the following operations:
//•	Add first to the second.
//•	Divide (integer) the result of the first operation by the third number.
//•	Multiply the result of the second operation by the fourth number. 
//Print the result after the last operation.

//Constraints 
//•	First number will be in the range [-2,147,483,648…2,147,483,647].
//•	Second number will be in the range [-2,147,483,648…2,147,483,647].
//•	Third number will be in the range [-2,147,483,648…2,147,483,647].
//•	Fourth number will be in the range [-2,147,483,648…2,147,483,647].

int firstNum = int.Parse(Console.ReadLine());
int secontNum = int.Parse(Console.ReadLine());
int thirdNum = int.Parse(Console.ReadLine());
int fourNum = int.Parse(Console.ReadLine());
double sumOfNum = ((firstNum + secontNum) / thirdNum) * fourNum;
Console.WriteLine($"{sumOfNum}");

//Create a program that receives a single integer. Your task is to find the sum of its digits.
//For example: 12345 → 1 + 2 + 3 + 4 + 5 = 15 

int num = int.Parse(Console.ReadLine());//12345
int sum = 0;
int n1 = num;

do
{
    sum += n1 % 10;//5
    n1 = n1 / 10;//1234
}
while (n1 > 0);

Console.WriteLine(sum);
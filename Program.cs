

// Console.WriteLine(6/6);
// string myName = "Bamiji";
// Console.WriteLine(myName);

// const int myNum = 3;
// Console.WriteLine(myNum);

// string name = "Bamiji";
// Console.WriteLine("my name is " + name);


// var age = 1;
// var name = "Abdulsalam";
// var letter = 'J';

// Console.WriteLine(age);
// Console.WriteLine(name);
// Console.WriteLine(letter);

// char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u' };

// string[] cars = {"Mazda", "Corrola", "Toyota"};
// cars[2] = "Opel";
// Console.WriteLine(cars[2]);



//for loop
// int[] integers = { 50, 100, 150, 200 };
// int sum = 0;
// int average = 0;

// for (int i = 0; i < integers.Length; i++)
// {
//     sum = sum + integers [i];
//     average = average / integers [i];
// }

// Console.WriteLine($"the answer is : {sum}");

// Console.WriteLine($"the average is : {average}");



//while loop
// int[] integers = { 50, 100, 150, 200 };
// int sum = 0;

// int i = 0;
// while (i < integers.Length)
// {
//      sum = sum + integers[i];
//      i++;
// }

// Console.WriteLine($"the answer is : {sum}");


//do while
// int[] integers = { 50, 100, 150, 200 };
// int sum = 0;
// // int average = 0;

// int s = 0;
// do
// {
//     sum = sum + integers[s];
//     s++;
// }while (s < integers.Length);

//  Console.WriteLine($"the answer is : {sum}");

// int m = 0;
// while(m < 9)
// {
//     Console.WriteLine(m);
//     m++;

// }


// Console.WriteLine("Enter your username");
// string userName = Console.ReadLine();

// Console.WriteLine("Your username is: " + userName);

// Console.WriteLine("Enter your height");
// int yourHeight = Convert.ToInt32(Console.ReadLine());

// if (yourHeight <= 140)
// {
//     Console.WriteLine("your dwarf");
// }
// else
// {
//     Console.WriteLine("your are short");
// }

// string userName = "Fatokun Abdulsalam";

// Console.WriteLine("Your name is " + userName);

// const int userNum = 20;
// userNum = 30;
// Console.WriteLine(userNum);

// int userNum = 300, userNum1 = 200, userNum2 = 30;

// Console.WriteLine($"Your total answer is {userNum + userNum1 + userNum2}");


// double c = 34.5;

// int d = Convert.ToInt16(c);

// Console.WriteLine(d);

// int a = 34;
// double s = Convert.ToDouble(a) + 0.2;

// Console.WriteLine(s);


// Console.WriteLine("what is your name");

// string userName = Console.ReadLine();

// Console.WriteLine("your name is " + userName);

// int y = 6;
// int u = 3;

// Console.WriteLine(y > u);

// Console.WriteLine(Math.Min(5,7));

// Console.WriteLine(Math.Sqrt(81));

// string txt = "whats your name";
// Console.WriteLine(txt.ToLower());


//string concatenation

// string firstName = "Abdulsalam ";
// string lastName = "Fatokun";
// string name = string.Concat("Your name is " + firstName + lastName);

// Console.WriteLine(name);

// How to use special characters like '," and \
// Console.WriteLine("it\'s");
// Console.WriteLine("it\"s");
// Console.WriteLine("it\\s"); 

//using if and else statement
// int myInputAge = 28;
// int voteAge = 18;

// if (myInputAge >= voteAge)
// {
//     Console.WriteLine("You\'re eligible to vote");
// }
// else
// {
//     Console.WriteLine("You\'re not 18 yet");
// }


// var userName = "hello world";
// Console.WriteLine(userName);

// int myNum = 8, userNum = 90, userNum1 = 2000;
// Console.WriteLine(myNum+userNum+userNum1);

// int myNum, userNum, userNum1;
// myNum = userNum = userNum1 = 2000;
// Console.WriteLine(myNum+userNum+userNum1);

// myAge = 20;
// myAge += 10;
//  myAge -= 10;
//  myAge *= 10;
//  myAge /= 10;
//
//  myAge = myAge % 10;


// Console.WriteLine(myAge);



//Method

//1. void method
// Console.WriteLine();
// SayHelloWorld();


// void  SayHelloWorld()
// {
//     Console.WriteLine("Hello World");
// }

// Console.WriteLine();
// SayMyName();

// void SayMyName()
// {
//     Console.WriteLine("Abdulsalam");
// }

// CalculateTheNum();
// CalculateTheNum();

// void CalculateTheNum()
// {

// int m = 8;
// int n = 9;
//     Console.WriteLine(m + n);
// }

// FindTheSqrt();

// void FindTheSqrt()
// {
//     int myNum = 100;
    
//       Console.WriteLine(Math.Sqrt(myNum));
// }


// //return mtehod
// Console.WriteLine(AddTwoNum());

// AddTwoNum();

// int AddTwoNum()
// {
//      int firstNum = 5;
//      int secondNum = 10;

//      return firstNum + secondNum;
// }

// //arguments 
// Console.WriteLine(AddTwoNumbers(19 , 4));

// //parameters and 
// int AddTwoNumbers(int a, int b)
// {
//     return a + b;
// }

// //Assignment

// //void
// Console.WriteLine("Calculate two numbers");

// Console.WriteLine("Enter your first digits");
// int userNum1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter your second digits");
// int userNum2 = Convert.ToInt32(Console.ReadLine());

// SayUserNumber();

// void SayUserNumber()
// {
//     Console.WriteLine(userNum1 + userNum2);
// }
 

// //return

// Console.WriteLine(CheckElectionEligibility(18));
// bool CheckElectionEligibility(int age)
// {
//     Console.WriteLine("Enter your age");
//     int userAge = Convert.ToInt32(Console.ReadLine());

//     return age >= 18 ? true : false;
// }


// int c = 0;

// while(c <= 20)
// {
//     Console.WriteLine("Number " + c);
//     c++;
// }

Console.WriteLine("The input number = ");
int x = Convert.ToInt16(Console.ReadLine()!);



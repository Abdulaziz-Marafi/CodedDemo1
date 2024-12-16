// Dataype Var-Name;

string FirstName = "Ahmad";
string LastName = "Damra";

int num1, num2;

num1 = 5;
num2 = 7;
int num3 = num1 + num2;

//Console.WriteLine("Mr. "+FirstName+" "+LastName);
Console.WriteLine("Mr." + FirstName + " " + LastName + ", Your number is: " + (num1 + num2));
Console.WriteLine("Mr." + FirstName + " " + LastName + ", Your number is: " + num3);

string N1, N2, N3;
N1 = "3";
N2 = "4";
N3 = "5";
//int N4 = (int)N3;

Console.WriteLine((string) N3);

int Total = Convert.ToInt32(N1) + Convert.ToInt32(N2) + Convert.ToInt32(N3);

Console.WriteLine("Total is: "+Total);

Console.WriteLine("-------------------------------");
Console.WriteLine("Enter Your Name: ");
string FullName = Console.ReadLine();

Console.WriteLine("Enter Your City: ");
string City = Console.ReadLine();

Console.WriteLine("Welcome " + FullName + " My City is: "+ City);

// Next task

string sumNum1, sumNum2;
Console.WriteLine("Enter the first number: ");
sumNum1 = Console.ReadLine();
Console.WriteLine("Enter the second number: ");
sumNum2 = Console.ReadLine();

int sum = Convert.ToInt32(sumNum1) + Convert.ToInt32(sumNum2); 

Console.WriteLine("The sum of the two numbers is: "+ sum );

// New task 

Console.WriteLine("-------------------------------");
Console.WriteLine("Enter Average: ");


double avg = Convert.ToDouble(Console.ReadLine());
if (avg >= 50 && avg <= 100)
{
    Console.WriteLine("Pass");
}else if (avg < 50 && avg >= 0)
{
    Console.WriteLine("Fail");
}else 
{
    Console.WriteLine("OutofRange");
}

// New Task:












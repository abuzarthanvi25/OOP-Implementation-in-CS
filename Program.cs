using System;

namespace CsharpLearning
{
    class Program
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static void Main(string[] args)
        {
            //ANCHOR - INTERFACE FUNCTIONALITY
            MyClass myObject = new MyClass();

            //ANCHOR - METHOD OVERLOADING
            myObject.Method1();
            myObject.Method1(222);

            int parameterValue = 42;
            string result = myObject.Method1(parameterValue);
            Console.WriteLine(result);

            //ANCHOR - INHERITENCE FUNCTIONALITY
            Dog myDog = new Dog();
            myDog.Species = "Pitbull";
            myDog.NumberOfLegs = 3;

            myDog.Walk();
            myDog.Voice();

            Console.WriteLine($"Species: {myDog.Species}, Legs: {myDog.NumberOfLegs}");

            //ANCHOR - ENCAPSULATION FUNCTIONALITY
            BankAccount account = new BankAccount();

            account.Deposit(1000);
            account.Withdraw(500);

            decimal balance = account.GetBalance();
            Console.WriteLine($"Current balance: {balance}");
        }

    }

    //ANCHOR - INTERFACE DEFINITION
    public interface MyInterface
    {
        void Method1();
        string Method1(int parameter);
    }

    //ANCHOR - INTERFACE IMPLEMENTATION
    public class MyClass : MyInterface
    {
        public void Method1()
        {
            Console.WriteLine("Method1 implementation in MyClass");
        }

        public string Method1(int parameter)
        {
            return $"Method2 implementation in MyClass with parameter: {parameter}";
        }
    }

    //ANCHOR - INHERITENCE IMPLEMENTATION

    // Parent Class
    public class Animal
    {
        public string Species { get; set; }

        public void Voice()
        {
            Console.WriteLine("ANIMAL SPEAKING");
        }
    }

    // Child Class
    public class Dog : Animal
    {
        public int NumberOfLegs { get; set; }

        public void Walk()
        {
            Console.WriteLine("Dog is walking");
        }
    }

    //ANCHOR - ENCAPSULATION IMPLEMENTATION
    public class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            // Perform validation and update balance
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount} units.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(decimal amount)
        {
            // Perform validation and update balance
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount} units.");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid withdrawal amount.");
            }
        }

        public decimal GetBalance()
        {
            // Provide read-only access to the balance
            return balance;
        }
    }


}

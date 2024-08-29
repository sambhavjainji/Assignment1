using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _netlab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A1Q1
            //Console.WriteLine(A1Q1.CalPrice(500, 400, 500, 700, 900));
            //Console.ReadLine();

            //A2Q2
            //int temp=int.Parse(Console.ReadLine());
            //if (temp < 0)
            //{
            //    Console.WriteLine("Temperature is too cold");
            //}
            //else
            //{
            //    Console.WriteLine(A2Q2.C2F(temp));
            //}
            //Console.ReadLine();

            //A3Q3
            //Console.WriteLine(A3Q3.Display());
            //A3Q3.Deposit(300000);
            //Console.WriteLine(A3Q3.Display());
            //A3Q3.Withdrawl(130000);
            //Console.ReadLine();


            //A4Q4
            //Console.Write("Enter Marks for Subject1: ");
            //int sub1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Marks for Subject2: ");
            //int sub2= int.Parse(Console.ReadLine());
            //Console.Write("Enter Marks for Subject3: ");
            //int sub3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Marks for Subject4: ");
            //int sub4 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Marks for Subject5: ");
            //int sub5 = int.Parse(Console.ReadLine());
            //if(sub1<0 ||sub1>100|| sub2 < 0 || sub2 > 100|| sub3 < 0 || sub3 > 100|| sub4 < 0 || sub4> 100|| sub5 < 0 || sub5 > 100)
            //{
            //    Console.WriteLine("Please Enter the marks between 0 &100");
            //}
            //else
            //Console.WriteLine("Your Grade is: "+A4Q4.Grade(sub1,sub2,sub3,sub4,sub5));
            //Console.ReadLine();
            //A5Q5
            //Console.Write("Enter the password : ");
            //string password = Console.ReadLine();
            //A5Q5.Validate(password);
            //Console.ReadLine();
            //A6Q6
            //Console.Write("Enter the distance traveled (in kilometers): ");
            //double distance = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Did the ride occur after 10 PM? (yes/no): ");
            //string nightRide = Console.ReadLine().ToLower();
            //double fare = A6Q6.Charges(distance, nightRide == "yes");
            //Console.WriteLine($"The total fare for the ride is: Rs. {fare}");
            //Console.ReadLine();
            //A7Q7
            //    bool[] attendance = new bool[5];
            //    for (int i = 0; i < attendance.Length; i++)
            //    {
            //        Console.Write($"Was the student present on day {i + 1}? (yes/no): ");
            //        string input = Console.ReadLine().ToLower();
            //        attendance[i] = input == "yes";
            //    }
            //    int totalDaysAttended = A7Q7.attendance(attendance);
            //    bool hasPerfectAttendance = totalDaysAttended == attendance.Length;
            //    Console.WriteLine($"\nTotal days attended: {totalDaysAttended}");
            //    Console.WriteLine(hasPerfectAttendance ? "The student has perfect attendance." : "The student does not have perfect attendance.");
            //    Console.ReadLine();

            //A8Q8
            //string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //A8Q8.Expense(months);
            //Console.ReadLine();
            //A9Q9
            //A9Q9.fun();
            //Console.ReadLine();
            //A10Q10
            //Console.Write("Enter the hourly wage: Rs. ");
            //double hourlyWage = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the number of hours worked in a week: ");
            //double hoursWorkedPerWeek = Convert.ToDouble(Console.ReadLine());

            //double monthlySalary = A10Q10.CalSal(hourlyWage, hoursWorkedPerWeek);

            //Console.WriteLine($"\nThe monthly salary is: Rs. {monthlySalary}");
        


    }
    class A1Q1
        {
            //Write a C# program to calculate the total price of items in a shopping cart. The cart contains 5 items with different prices. Include a 10% discount if the total price exceeds Rs. 3000.

            public static int CalPrice(int item1, int item2, int item3, int item4, int item5) {
                int sum = item1 + item2 + item3 + item4 + item5;
                if (sum >= 3000)
                {
                    return sum - sum * 10 / 100;
                }
                else
                    return sum;

            }

        }
        class A2Q2
        {
            //Develop a C# application that allows the user to input a temperature in Celsius and convert it to Fahrenheit. If the input temperature is below 0°C, display a warning message about freezing temperatures.

            public static int C2F(int temp)
            {

                return (temp * 9 / 5) + 32;

            }
        }
        class A3Q3
        {
            //Create a C# program that simulates a simple ATM. It should allow users to check their balance, deposit money, and withdraw money. Ensure that the program checks for sufficient funds before allowing a withdrawal.

            static int balance = 0;
            public static int Display()
            {

                return balance;

            }
            public static void Deposit(int amt)
            {
                balance += amt;
                Console.WriteLine("Money Deposited");
            }
            public static void Withdrawl(int amt)
            {
                if (amt > balance)
                {
                    Console.WriteLine("Insufficient Balance");

                }
                else
                {
                    balance -= amt;
                    Console.WriteLine("Please Withdraw Your Money: " + amt);
                    Console.WriteLine("Remaining Balance: " + balance);
                }
                Console.ReadLine();
            }
        }
        class A4Q4
        {
            //Write a C# program to take the marks of five subjects from a user and calculate the average. Based on the average, determine and display the grade (A, B, C, D, or F).
            public static char Grade(int sub1, int sub2, int sub3, int sub4, int sub5)
            {
                int avg = (sub1 + sub2 + sub3 + sub4 + sub5) / 5;
                if (avg >= 90 && avg <= 100)
                    return 'A';
                else if (avg >= 80 && avg <= 89)
                    return 'B';
                else if (avg >= 70 && avg <= 79)
                    return 'C';
                else if (avg >= 60 && avg <= 69)
                    return 'D';
                else
                    return 'F';
            }
        }
        class A5Q5
        {
            //Develop a C# application that asks the user to enter a password. The password should be validated based on the following criteria: at least 8 characters long, contains at least one uppercase letter, one lowercase letter, and one number. Display appropriate messages based on the validation result.

            public static void Validate(String str)
            {
                bool isLower = false;
                bool isUpper = false;
                bool isDigit = false;
                if (str.Length > 7)
                {
                    foreach (char c in str)
                    {
                        if (char.IsDigit(c))
                            isDigit = true;
                        else if (char.IsLower(c))
                            isLower = true;
                        else if (char.IsUpper(c))
                            isUpper = true;
                    }
                    if (isUpper && isLower && isDigit)
                    {
                        Console.WriteLine("password is valid");
                        return;
                    }
                }
                Console.WriteLine("Password is invalid.");

            }
        }
        class A6Q6
        {
            //Write a C# program to calculate the fare of a taxi ride. The fare is calculated based on the distance traveled. The first 2 kilometers are charged at a flat rate (Rs. 20), and any additional kilometers are charged at a per-kilometer rate. Include a night surcharge if the ride occurs after 10 PM.
            public static double Charges(double distance, bool isNightRide)
            {
                double baseFare = 20.0;
                double additionalFareRate = 10.0;
                double nightSurchargeRate = 1.5;
                double fare = baseFare;
                if (distance > 2)
                {
                    fare += (distance - 2) * additionalFareRate;
                }
                if (isNightRide)
                {
                    fare *= nightSurchargeRate;
                }
                return fare;
            }
        }
        class A7Q7
        {
            //A school tracks the attendance of students over 5 days. The system should be able to record attendance, calculate the total number of days attended, and identify if a student has perfect attendance.
            public static int attendance(bool[] attendance)
            {
                int totalDays = 0;
                foreach (bool attended in attendance)
                {
                    if (attended)
                    {
                        totalDays++;
                    }
                }
                return totalDays;
            }
        }
        class A8Q8
        {
            // Q8. An individual tracks their expenses for each month in a year. 
            // Calculate the total expenses for the year and identify the month with the highest and lowest expenses.
            public static void Expense(string[] months) {
                double[] monthlyExpenses = new double[12];



                for (int i = 0; i < monthlyExpenses.Length; i++)
                {
                    Console.Write($"Enter expenses for {months[i]}: ");
                    monthlyExpenses[i] = Convert.ToDouble(Console.ReadLine());
                }
                double totalExpenses = 0;
                foreach (double expense in monthlyExpenses)
                {
                    totalExpenses += expense;
                }


                double maxExpense = monthlyExpenses[0];
                double minExpense = monthlyExpenses[0];
                int maxExpenseMonth = 0;
                int minExpenseMonth = 0;

                for (int i = 1; i < monthlyExpenses.Length; i++)
                {
                    if (monthlyExpenses[i] > maxExpense)
                    {
                        maxExpense = monthlyExpenses[i];
                        maxExpenseMonth = i;
                    }

                    if (monthlyExpenses[i] < minExpense)
                    {
                        minExpense = monthlyExpenses[i];
                        minExpenseMonth = i;
                    }
                }





                Console.WriteLine($"\nTotal expenses for the year: Rs. {totalExpenses}");
                Console.WriteLine($"Highest expenses were in {months[maxExpenseMonth]}: Rs. {maxExpense}");
                Console.WriteLine($"Lowest expenses were in {months[minExpenseMonth]}: Rs. {minExpense}");

                Console.ReadLine();
            }
        }
        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Item(string name, double price)
            {
                this.Name = name;
                this.Price = price;
            }
        }
        class Cart
        {
            private List<Item> items;

            public Cart()
            {
                items = new List<Item>();
            }

            public void AddItem(Item item)
            {
                items.Add(item);
                Console.WriteLine($"{item.Name} added to the cart.");
                Console.ReadLine();
            }

            public void RemoveItem(string itemName)
            {
                Item itemToRemove = items.Find(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
                if (itemToRemove != null)
                {
                    items.Remove(itemToRemove);
                    Console.WriteLine($"{itemToRemove.Name} removed from the cart.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{itemName} not found in the cart.");
                    Console.ReadLine();
                }
            }

            public void ViewCart()
            {
                if (items.Count == 0)
                {
                    Console.WriteLine("Your cart is empty.");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("\nItems in your cart:");
                foreach (Item item in items)
                {
                    Console.WriteLine($"{item.Name}: Rs. {item.Price}");
                    Console.ReadLine();
                }

                double totalPrice = CalculateTotalPrice();
                Console.WriteLine($"\nTotal price: Rs. {totalPrice}");
                Console.ReadLine();
            }

            private double CalculateTotalPrice()
            {
                double total = 0;
                foreach (Item item in items)
                {
                    total += item.Price;
                }
                return total;
            }
        }
        class A9Q9 {
            //Implement a shopping cart system where a user can add items, remove items, and view the total price.Assume each item has a name and a price
            public static void fun()
            {
                Cart cart = new Cart();

                while (true)
                {
                    Console.WriteLine("\nShopping Cart Menu:");
                    Console.WriteLine("1. Add Item");
                    Console.WriteLine("2. Remove Item");
                    Console.WriteLine("3. View Cart");
                    Console.WriteLine("4. Exit");
                    Console.Write("Select an option (1-4): ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the item name: ");
                            string itemName = Console.ReadLine();
                            Console.Write("Enter the item price: ");
                            double itemPrice = Convert.ToDouble(Console.ReadLine());
                            cart.AddItem(new Item(itemName, itemPrice));
                            break;

                        case 2:
                            Console.Write("Enter the name of the item to remove: ");
                            string removeItemName = Console.ReadLine();
                            cart.RemoveItem(removeItemName);
                            break;

                        case 3:
                            cart.ViewCart();
                            break;

                        case 4:
                            Console.WriteLine("Exiting the shopping cart. Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Invalid option. Please select 1-4.");
                            break;
                    }
                }
            }
        }
        class A10Q10
        {
            //Create a program that calculates the monthly salary of an employee based on their hourly wage and the number of hours worked in a week. Consider that there are 4 weeks in a month.
            public static double CalSal(double hourlyWage, double hoursWorkedPerWeek)
            {
                const int weeksInMonth = 4;
                double weeklySalary = hourlyWage * hoursWorkedPerWeek;
                return weeklySalary * weeksInMonth;
            }
        }
    


    }
}



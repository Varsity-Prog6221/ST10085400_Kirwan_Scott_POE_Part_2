using System;
using System.Collections.Generic;
using System.Linq;

namespace ST10085400_Kirwan_Scott_POE_Part_2
{
    class Program
    {
        delegate void Dlg(String del);//Delegate is triggered once an event takes place
        static void Main(string[] args)
        {
            double Income = 0; //Gross income the user earns monthly
            double taxDeduct = 0; //Tax deducted after recieving monthly income
            double groceries = 0; //amount spent on groceries a month
            double waterAndLights = 0; //amount of water and lights spent during a month
            double travCost = 0; //amount spent on travel a month
            double cellPhone = 0; //amount spent on cellphone expenses a month
            double otherexpenses = 0; //Any other expenses during the month



            Dictionary<string, double> expenselist = new Dictionary<string, double>(); //generic collection to store the expenses
            Console.WriteLine("-----------------------WELCOME-----------------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Gross monthly income: ");
            Income = Convert.ToDouble(Console.ReadLine()); //Enter monthly income

            Console.WriteLine("-----\nEstimated monthly tax deducted: ");
            taxDeduct = Convert.ToDouble(Console.ReadLine()); //Enter tax amount
            expenselist.Add("Estimated monthly tax deducted", taxDeduct); //stores the amount in the array/general collection

            Console.WriteLine("-----\nEstimated monthly expenditures in each of the following categories: \n");
            Console.WriteLine("Groceries: "); //enter groceries amount
            groceries = Convert.ToDouble(Console.ReadLine());
            expenselist.Add("Groceries", groceries); //stores the amount in the array/general collection

            Console.WriteLine("-----\nWater and lights: ");
            waterAndLights = Convert.ToDouble(Console.ReadLine());
            expenselist.Add("Water and lights", waterAndLights); //stores the amount in the array/general collection

            Console.WriteLine("-----\nTravel costs (petrol included): ");
            travCost = Convert.ToDouble(Console.ReadLine());
            expenselist.Add("Travel costs (petrol included)", travCost); //stores the amount in the array/general collection

            Console.WriteLine("-----\nCellphone and/or Telephone: ");
            cellPhone = Convert.ToDouble(Console.ReadLine());
            expenselist.Add("Cellphone and/or Telephone", cellPhone); //stores the amount in the array/general collection

            Console.WriteLine("-----\nOther expenses: ");
            otherexpenses = Convert.ToDouble(Console.ReadLine());
            expenselist.Add("Other expenses", otherexpenses); //stores the amount in the array/general collection
            Console.WriteLine("\n ----------------------------------------------------\n");

            Console.WriteLine("\n ----------------------------------------------------\n" +
                "For Renting accommodation select 1 \nFor buying a property select 2: \n");
            Console.WriteLine("1. Renting accommodation (1)");
            Console.WriteLine("2. Buying a property (2)");

            int choose = 0;
            double monthlyRent = 0;
            double propPrice = 0;
            double totDeposit = 0;
            double intRate = 0;
            int monthlypay = 0;
            double eMI = 0;

            choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Monthly rental amount");
                monthlyRent = Convert.ToDouble(Console.ReadLine());
                expenselist.Add("Monthly rental amount", monthlyRent);//stores the amount in the array/general collection
                Console.WriteLine("----------------------------------------------------");
            }
            else if (choose == 2)
            {
                Console.WriteLine("\n----------------------------------------------------");
                Console.WriteLine("Purchase price of property");
                propPrice = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("\nTotal deposit");
                totDeposit = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("\nInterest rate (percentage)");
                intRate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nNumber of months to repay (between 240 and 360)");
                monthlypay = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nMonthly home loan repayment for buying a property");
                eMI = emi_calculator(propPrice - totDeposit, intRate, monthlypay / 12);
                if (eMI > Income / 3)
                {
                    Console.WriteLine("Approval of the home loan is unlikely");
                }
                expenselist.Add("Home Loan EMI", eMI);
                Console.WriteLine("----------------------------------------------------\n\n\n");
            }
            double availableMoney = 0;
            if (choose == 1)//If 1 is chosen the first calculation wll be applied
            {
                availableMoney = Income - (taxDeduct + groceries + waterAndLights + travCost + cellPhone + otherexpenses + monthlyRent);

            }
            else if (choose == 2)//if 2 is chosen the second calculation will be applied
            {
                availableMoney = Income - (taxDeduct + groceries + waterAndLights + travCost + cellPhone + otherexpenses + eMI);
            }

            Console.WriteLine("Available monthly money after all the specified deductions have been made: R{0}", availableMoney);

            double VehEmi = BuyVehicle();
            if (VehEmi > 0)
            {
                expenselist.Add("Vehicle EMI", VehEmi);
            }

            double TotalExpense = 0;

            if (choose == 1)
            {
                TotalExpense = taxDeduct + groceries + waterAndLights + travCost + cellPhone + otherexpenses + monthlyRent + VehEmi;
                expenselist.Add("Total Expenses", TotalExpense);
            }
            else if (choose == 2)
            {
                TotalExpense = taxDeduct + groceries + waterAndLights + travCost + cellPhone + otherexpenses + eMI + VehEmi;
                expenselist.Add("Total Expenses", TotalExpense);
            }
            double finalAmount = Income - TotalExpense;
            expenselist.Add("Final Amount", finalAmount);
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Estimated Final Amount : R{0}", finalAmount);
            Console.WriteLine("\n------------------------------------\n");


            if (TotalExpense > (Income * 3 / 4))//Delegate event is triggered once the Total expenses is equal to ore than 75% of gross income
            {
                Dlg del = delegate (string str)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Total Expenses are greater that 75% of your gross income");
                    Console.WriteLine("------------------------------------------");
                };
            }

            Console.WriteLine("------------------------------------------");

            Console.WriteLine("Expenses that the user has accumulated:\n");
            Console.WriteLine("----");

            foreach (KeyValuePair<string, double> expin in expenselist.OrderBy(key => key.Value)) //Displays the expenses that is stored in the array
            {

                Console.WriteLine(expin.Key + " R" + expin.Value + "\n----");



            }
            Console.WriteLine("available monthly money: R{0}", finalAmount);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("-----------------------GOODBYE-----------------------");
            Console.ReadLine();
        }

        static double emi_calculator(double p, double r, double t)//method to calculate the montly repayments for a home loan
        {
            double emi;

            r = r / (12 * 100); // one month interest
            t = t * 12; // one month period
            emi = (p * r * (float)Math.Pow(1 + r, t)) /
                (float)(Math.Pow(1 + r, t) - 1);

            return (emi);
        }

        static double BuyVehicle()//method for calculating the Vehicle EMI and obtaining car details
        {
            Console.WriteLine("Want to buy a vehicle, select 1 or 2");
            Console.WriteLine("1: Yes");
            Console.WriteLine("2: No");
            double VehEmi = 0;
            int select = Convert.ToInt32(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("Model and make");
                string make = Console.ReadLine();
                Console.WriteLine("Purchase price");
                double purchasePrice = 0;
                double.TryParse(Console.ReadLine(), out purchasePrice);
                Console.WriteLine("Total deposit");
                double totalDeposit = 0;
                double.TryParse(Console.ReadLine(), out totalDeposit);
                Console.WriteLine("Interest rate (percentage)");
                double interestRate = 0;
                double.TryParse(Console.ReadLine(), out interestRate);
                Console.WriteLine("Estimated insurance premium");
                double estInsPremium = 0;
                double.TryParse(Console.ReadLine(), out estInsPremium);
                VehEmi = emi_calculator(purchasePrice - totalDeposit + estInsPremium, interestRate, 5);
            }
            return VehEmi;
        }
    }}

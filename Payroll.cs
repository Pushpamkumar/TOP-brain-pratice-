using System;
using System.Collections.Generic;

// Abstract base class representing a generic employee
public abstract class Employee
{
    // Each employee must implement how pay is calculated
    public abstract decimal CalculatePay();
}

// Hourly employee: pay = rate * hours
public class HourlyEmployee : Employee
{
    private decimal rate;
    private decimal hours;

    // Constructor to initialize rate and hours
    public HourlyEmployee(decimal rate, decimal hours)
    {
        this.rate = rate;
        this.hours = hours;
    }

    // Calculate hourly employee pay
    public override decimal CalculatePay()
    {
        return rate * hours;
    }
}

// Salaried employee: pay = monthly salary
public class SalariedEmployee : Employee
{
    private decimal monthlySalary;

    // Constructor to initialize monthly salary
    public SalariedEmployee(decimal monthlySalary)
    {
        this.monthlySalary = monthlySalary;
    }

    // Calculate salaried employee pay
    public override decimal CalculatePay()
    {
        return monthlySalary;
    }
}

// Commission employee: pay = base salary + commission
public class CommissionEmployee : Employee
{
    private decimal commission;
    private decimal baseSalary;

    // Constructor to initialize commission and base salary
    public CommissionEmployee(decimal commission, decimal baseSalary)
    {
        this.commission = commission;
        this.baseSalary = baseSalary;
    }

    // Calculate commission employee pay
    public override decimal CalculatePay()
    {
        return baseSalary + commission;
    }
}

public class Program
{
    // Method to calculate total payroll using polymorphism
    public static decimal TotalPayroll(string[] employees)
    {
        decimal total = 0;

        // Process each employee input string
        for (int i = 0; i < employees.Length; i++)
        {
            string[] parts = employees[i].Split(' ');
            Employee emp = null;

            // Identify employee type and create corresponding object
            if (parts[0] == "H")
            {
                emp = new HourlyEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2]));
            }
            else if (parts[0] == "S")
            {
                emp = new SalariedEmployee(decimal.Parse(parts[1]));
            }
            else if (parts[0] == "C")
            {
                emp = new CommissionEmployee(decimal.Parse(parts[1]), decimal.Parse(parts[2]));
            }

            // Add calculated pay to total
            if (emp != null)
            {
                total += emp.CalculatePay();
            }
        }

        // Round total payroll to 2 decimals (AwayFromZero)
        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main()
    {
        // Sample input
        string[] employees =
        {
            "H 50 10",
            "S 3000",
            "C 500 2000"
        };

        // Print total payroll
        Console.WriteLine(TotalPayroll(employees));
    }
}

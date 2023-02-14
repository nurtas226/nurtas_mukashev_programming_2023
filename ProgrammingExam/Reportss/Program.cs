using System;
using Microsoft.EntityFrameworkCore;
using Reportss;
using static System.Net.Mime.MediaTypeNames;

using var context = new ProgramminClassesContext();
foreach (var customer in context.Customers)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} (Company Name: {customer.CompanyName}) (ID: {customer.CustomerId})");
}

var me = new Customer
{
    FirstName = "Nurtas",
    LastName = "Mukashev",
    PasswordHash = "password",
    PasswordSalt = "lala123",
    CompanyName = "Facebook"
};

context.Customers.Add(me);
context.SaveChanges();


Console.WriteLine("Updated table");

foreach (var customer in context.Customers)
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName} (Company Name: {customer.CompanyName}) (ID: {customer.CustomerId})");
}
using Classe_abstrata.Entities;
using System;
using System.Collections.Generic;

namespace Classe_abstrata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company(i / c) ?");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        double healthexpenditures = double.Parse(Console.ReadLine());
                        list.Add(new IndividualTaxPayer(name, anualIncome, healthexpenditures));
                        break;

                    case 'c':
                        Console.Write("Number of employees: ");
                        int employes = int.Parse(Console.ReadLine());
                        list.Add(new CompanyTaxPayer(name, anualIncome, employes));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (TaxPayer item in list)
            {
                Console.WriteLine(item.Name + ": $ " + item.tax().ToString("F2"));
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            double sum = 0.0;
            foreach (TaxPayer item in list)
            {
                sum += item.tax();
            }
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"));
        }
    }
}
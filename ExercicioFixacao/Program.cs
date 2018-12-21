using ExercicioFixacao.Entities;
using ExercicioFixacao.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InstalledUICulture);
            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PayPalService());
            contractService.ProcessContract(contract, numberOfInstallments);

            Console.WriteLine("Installments: ");

            for (int i = 0; i < contract.Installments.Count; i++)
            {
                Console.WriteLine(contract.Installments[i].DueDate.ToShortDateString() +
                    " - " +
                    contract.Installments[i].Amount);
            }
            

            Console.ReadKey();           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingProject.Models
{
    public class Parking
    {
        private decimal startingPrice = 0;
        private decimal hourlyPrice = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal startingPrice, decimal hourlyPrice)
        {
            this.startingPrice = startingPrice;
            this.hourlyPrice = hourlyPrice;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string licensePlate =Console.ReadLine();
            vehicles.Add(licensePlate.ToUpper());
            Console.WriteLine("Veículo adicionado.");
        }

        public void DeleteVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para remover: ");
            string licensePlate = Console.ReadLine();


            if(vehicles.Any(x => x.ToUpper() == licensePlate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                int hour = int.Parse(Console.ReadLine());

                decimal totalValue = startingPrice + (hourlyPrice * hour);

                vehicles.Remove(licensePlate.ToUpper());

                Console.WriteLine($"O veículo {licensePlate} foi removido e o preço total foi de: R$ {totalValue}");
            } else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListVehicles()
        {
            if(vehicles.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");

                foreach(var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle);
                }
            } else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
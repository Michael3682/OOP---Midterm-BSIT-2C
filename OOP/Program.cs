using System;
using System.Collections.Generic;

namespace HotelReservationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Reservation> reservations = new List<Reservation>();

            bool continueRunning = true;

                Console.WriteLine("Welcome to our Hotel Reservation System");
            while (continueRunning)
            {
                int numberOfNights, roomChoice;

                // Ask for the guest's name
                Console.Write("\nMay I know your name? - ");
                string guestName = Console.ReadLine();

                // Show available rooms
                Console.WriteLine("\nHere are our rooms:");
                Console.WriteLine("1. Standard Room - [Max 2 Guests, PHP 240.00]");
                Console.WriteLine("2. Suite Room - [Max 4 Guests, PHP 400.00]");
                Console.WriteLine("3. Deluxe Room - [Max 4 Guests, PHP 600.00]");
                Console.WriteLine("4. Luxury Room - [Max 6 Guests, PHP 800.00]");

                // Choose room type
                Console.Write("\nChoose room number - ");
                while (!int.TryParse(Console.ReadLine(), out roomChoice) || !(roomChoice >= 1 && roomChoice <= 4))
                {
                    Console.Write("Please enter a valid room number (1-4): ");
                }

                // Get number of nights
                Console.Write("\nNumber of night/s you plan to stay? - ");
                while (!int.TryParse(Console.ReadLine(), out numberOfNights) || numberOfNights <= 0)
                {
                    Console.Write("Please enter a valid number of night/s: ");
                }

                // Reservation process
                Reservation reservation = null;
                if (roomChoice == 1)
                {
                    reservation = new StandardRoomReservation(guestName, numberOfNights, DateTime.Now);
                }
                else if (roomChoice == 2)
                {
                    reservation = new SuiteRoomReservation(guestName, numberOfNights, DateTime.Now);
                }
                else if (roomChoice == 3)
                {
                    reservation = new DeluxeRoomReservation(guestName, numberOfNights, DateTime.Now);
                }
                else if (roomChoice == 4)
                {
                    reservation = new LuxuryRoomReservation(guestName, numberOfNights, DateTime.Now);
                }

                // Add reservation to the list
                reservations.Add(reservation);

                // Print reservation details
                Console.WriteLine("\nHotel Reservations:\n");
                foreach (var res in reservations)
                {
                    res.PrintDetails();
                }

                // Ask if the user wants to make another reservation
                Console.Write("\nDo you want to make another reservation? (yes | no) - ");
                string userChoiceStr = Console.ReadLine().ToLower();
                while (userChoiceStr != "yes" && userChoiceStr != "no")
                {
                    Console.Write("Please enter 'yes' or 'no': ");
                    userChoiceStr = Console.ReadLine().ToLower();
                }

                if (userChoiceStr == "no")
                {
                    continueRunning = false;
                    Console.WriteLine("\nThank you for using our Hotel Reservation System! Goodbye.");
                }
            }
        }
    }
}

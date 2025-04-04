using System;

namespace HotelReservationSystem
{
    // Inherits from Reservation
    public class StandardRoomReservation : Reservation
    {
        public StandardRoomReservation(string guestName, int numberOfNights, DateTime reservationDate)
            : base(guestName, numberOfNights, reservationDate)
        {
        }

        public override void PrintDetails()
        {
            Console.WriteLine($" Standard Room Reservation for {GuestName}");
            Console.WriteLine($" Check-in Time: {ReservationDate.ToShortDateString()}");
            Console.WriteLine($" Staying at the hotel for {NumberOfNights} night{(NumberOfNights > 1 ? 's' : ' ')}");
            Console.WriteLine($" Total stay cost: PHP {CalculateCost()}\n");
        }

        public override decimal CalculateCost()
        {
            return 240 * NumberOfNights;
        }
    }
    public class SuiteRoomReservation : Reservation
    {
        public SuiteRoomReservation(string guestName, int numberOfNights, DateTime reservationDate)
            : base(guestName, numberOfNights, reservationDate)
        {
        }

        public override void PrintDetails()
        {
            Console.WriteLine($" Suite Room Reservation for {GuestName}");
            Console.WriteLine($" Check-in Time: {ReservationDate.ToShortDateString()}");
            Console.WriteLine($" Staying at the hotel for {NumberOfNights} night{(NumberOfNights > 1 ? 's' : ' ')}");
            Console.WriteLine($" Total stay cost: PHP {CalculateCost()}\n");
        }

        public override decimal CalculateCost()
        {
            return 400 * NumberOfNights;
        }
    }

    public class DeluxeRoomReservation : Reservation
    {
        public DeluxeRoomReservation(string guestName, int numberOfNights, DateTime reservationDate)
            : base(guestName, numberOfNights, reservationDate)
        {
        }

        public override void PrintDetails()
        {
            Console.WriteLine($" Deluxe Room Reservation for {GuestName}");
            Console.WriteLine($" Check-in Time: {ReservationDate.ToShortDateString()}");
            Console.WriteLine($" Staying at the hotel for {NumberOfNights} night{(NumberOfNights > 1 ? 's' : ' ')}");
            Console.WriteLine($" Total stay cost: PHP {CalculateCost()}\n");
        }

        public override decimal CalculateCost()
        {
            return 600 * NumberOfNights;
        }
    }

    public class LuxuryRoomReservation : Reservation
    {
        public LuxuryRoomReservation(string guestName, int numberOfNights, DateTime reservationDate)
            : base(guestName, numberOfNights, reservationDate)
        {
        }

        public override void PrintDetails()
        {
            Console.WriteLine($" Luxury Room Reservation for {GuestName}");
            Console.WriteLine($" Check-in Time: {ReservationDate.ToShortDateString()}");
            Console.WriteLine($" Staying at the hotel for {NumberOfNights} night{(NumberOfNights > 1 ? 's' : ' ')}");
            Console.WriteLine($" Total stay cost: PHP {CalculateCost()}\n");
        }

        public override decimal CalculateCost()
        {
            return 800 * NumberOfNights;
        }
    }
}
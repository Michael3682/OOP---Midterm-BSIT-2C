using System;

namespace HotelReservationSystem
{
    public abstract class Reservation
    {
        // Encapsulation: Private fields
        private string guestName;
        private int numberOfNights;
        private DateTime reservationDate;

        public string GuestName
        {
            get { return guestName; }
            set { guestName = value ?? throw new ArgumentNullException("Guest name cannot be null"); }
        }

        public int NumberOfNights
        {
            get { return numberOfNights; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of nights must be positive.");
                }
                numberOfNights = value;
            }
        }

        public DateTime ReservationDate
        {
            get { return reservationDate; }
            set { reservationDate = value; }
        }

        // Abstract method to be overridden in child classes
        public abstract void PrintDetails();

        // Constructor
        public Reservation(string guestName, int numberOfNights, DateTime reservationDate)
        {
            GuestName = guestName;
            NumberOfNights = numberOfNights;
            ReservationDate = reservationDate;
        }

        // Virtual method to calculate the cost (can be overridden)
        public virtual decimal CalculateCost()
        {
            return 0; // To be overridden by subclasses
        }
    }
}

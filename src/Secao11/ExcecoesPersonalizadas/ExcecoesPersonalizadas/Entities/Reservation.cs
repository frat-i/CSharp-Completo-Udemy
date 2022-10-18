using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcecoesPersonalizadas.Entities.Exceptions;

namespace ExcecoesPersonalizadas.Entities
{
    internal class Reservation
    {
        public int roomNumber { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomnumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException(" Check-Out date must be after the Check-In date");
            }

            roomNumber = roomnumber;
            checkIn = checkin;
            checkOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = checkOut.Subtract(checkIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException(" Check-Out date must be after the Check-In date");
            }

            checkIn = checkin;
            checkOut = checkout;
        }

        public override string ToString()
        {
            return $"Room: {roomNumber}, CheckIn {checkIn.ToString("dd/MM/yyyy")}, CheckOut {checkOut.ToString("dd/MM/yyyy")}, {Duration()} nights ";
        }
    }
}

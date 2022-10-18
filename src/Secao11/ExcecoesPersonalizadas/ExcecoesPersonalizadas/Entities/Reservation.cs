using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            this.roomNumber = roomNumber;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = checkOut.Subtract(checkIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            checkIn = checkin;
            checkOut = checkout;
        }

        public override string ToString()
        {
            return $"Room: {roomNumber}, CheckIn {checkIn.ToString("dd/MM/yyyy")}, CheckOut {checkOut.ToString("dd/MM/yyyy")}, {Duration()} nights ";
        }
    }
}

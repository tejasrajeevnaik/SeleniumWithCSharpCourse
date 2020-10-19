using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal abstract class Ticket
    {
        // Private variables
        private decimal ticketPrice;

        // Constructor
        public Ticket(int ticketId_C, decimal ticketPrice_C, TicketCategoryType ticketCategory_C)
        {
            TicketId = ticketId_C;
            TicketPrice = ticketPrice_C;
            TicketCategory = ticketCategory_C;
        }

        // Enums and Properties
        public int TicketId
        {
            get;
            set;
        }

        public decimal TicketPrice
        {
            get { return ticketPrice; }
            set
            {
                if(value < 1M)
                {
                    ticketPrice = 1M;
                }
                else
                {
                    ticketPrice = value;
                }
            }
        }

        public enum TicketCategoryType
        {
            Economy, FirstClass, Elite
        }

        public TicketCategoryType TicketCategory
        {
            get;
            set;
        }

        // Methods
    }
}

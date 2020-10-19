using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    internal abstract class Event : Ticket
    {
        // Private variables

        // Constructor
        public Event(int eventId_C, EventHallType eventHall_C, DateTime eventDateTime_C, int ticketId_C, decimal ticketPrice_C, TicketCategoryType ticketCategory_C) : base(ticketId_C, ticketPrice_C, ticketCategory_C)
        {
            EventId = eventId_C;
            EventHall = eventHall_C;
            EventDateTime = eventDateTime_C;
        }

        // Properties
        public int EventId
        {
            get;
            set;
        }

        public enum EventHallType
        {
            Hall1, Hall2, Hall3
        }

        public EventHallType EventHall
        {
            get;
            set;
        }

        public DateTime EventDateTime
        {
            get;
            set;
        }

        // Methods
    }
}

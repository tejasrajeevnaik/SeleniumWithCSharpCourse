using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
    class Play : Event
    {
        // Private variables

        // Constructor
        public Play(PlayNameType playName_C, int eventId_C, EventHallType eventHall_C, DateTime eventDateTime_C, int ticketId_C, decimal ticketPrice_C, TicketCategoryType ticketCategory_C) : base(eventId_C, eventHall_C, eventDateTime_C, ticketId_C, ticketPrice_C, ticketCategory_C)
        {
            PlayName = playName_C;
        }

        // Properties
        public enum PlayNameType
        {
            RomeoJuliet, HeerRanjha, LailaMajnu
        }

        public PlayNameType PlayName
        {
            get;
            set;
        }

        // Methods
        public override string ToString()
        {
            return $"PlayName: {PlayName}, EventId: {base.EventId}, EventHall: {base.EventHall}, EventDateTime: {base.EventDateTime}, TicketId: {base.TicketId}, TicketPrice: {base.TicketPrice}, TicketCategory: {base.TicketCategory}";
        }
    }
}

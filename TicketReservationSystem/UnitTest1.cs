using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketReservationSystem;

namespace TicketReservationSystemUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Play play = new Play(Play.PlayNameType.HeerRanjha, 123, Event.EventHallType.Hall1, DateTime.Today, 111, 9.99M, Ticket.TicketCategoryType.FirstClass);
            Console.WriteLine(play);

            play.PlayName = Play.PlayNameType.LailaMajnu;
            play.EventId = 12345;
            play.EventHall = Event.EventHallType.Hall2;
            play.EventDateTime = new DateTime(2020, 12, 1);
            play.TicketId = 11111;
            play.TicketPrice = 99.99M;
            play.TicketCategory = Ticket.TicketCategoryType.Elite;
            Console.WriteLine(play);
        }
    }
}

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
        }
    }
}

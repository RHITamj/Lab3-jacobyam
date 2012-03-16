using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
    [TestFixture()]
    public class FlightTest
    {
        int milesForFlight = 3;
        //TODO Task 7 items go here
        [Test()]
        public void TestFlightNotNull()
        {
            var target = new Flight(DateTime.Now, DateTime.MaxValue, milesForFlight);
            Assert.NotNull(target);
        }

        [Test()]
        public void TestGetMiles()
        {
            var target = new Flight(DateTime.Now, DateTime.MaxValue, milesForFlight);
            Assert.AreEqual(3, target.Miles);
        }

        [Test()]
        public void TestFlightsEqual()
        {
            var FlightA = new Flight(DateTime.Now, DateTime.MaxValue, milesForFlight);
            var FlightB = new Flight(DateTime.Now, DateTime.MaxValue, milesForFlight);
            Assert.True(FlightA.Equals(FlightB));
        }
    }
}

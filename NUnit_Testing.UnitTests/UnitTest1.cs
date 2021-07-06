using NUnit.Framework;
using NUnit_Testing.Fundamentals;

namespace NUnit_Testing.UnitTests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User{ IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }
    }
}

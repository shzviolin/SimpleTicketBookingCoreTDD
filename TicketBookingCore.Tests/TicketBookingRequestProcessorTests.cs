using FakeItEasy;
using FluentAssertions;

namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests
    {

        [Fact]
        public void Book_ValidRequest_SavesBookingAndReturnsResponse()
        {
            // Arrange
            var fakeRepository = A.Fake<ITicketBookingRepository>();
            var processor = new TicketBookingRequestProcessor(fakeRepository);
            var request = new TicketBookingRequest
            {
                FirstName = "Ali",
                LastName = "Ebrahimi",
                Email = "a.ebrahimi1367@gmail.com"
            };

            // Act
            var response = processor.Book(request);

            // Assert
            A.CallTo(() => fakeRepository.Save(A<TicketBooking>.Ignored)).MustHaveHappenedOnceExactly();
            response.Should().NotBeNull();
            response.FirstName.Should().Be(request.FirstName);
            response.LastName.Should().Be(request.LastName);
            response.Email.Should().Be(request.Email);
        }

        [Fact]
        public void Book_NullRequest_ThrowsArgumentNullException()
        {
            // Arrange
            var fakeRepository = A.Fake<ITicketBookingRepository>();
            var processor = new TicketBookingRequestProcessor(fakeRepository);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => processor.Book(null));
        }
    }
}

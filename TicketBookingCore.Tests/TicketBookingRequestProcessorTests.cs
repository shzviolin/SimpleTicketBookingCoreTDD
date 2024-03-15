namespace TicketBookingCore.Tests
{
    public class TicketBookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnTicketBookingResultWithRequestValues()
        {
            #region Arrange
            var processor = new TicketBookingRequestProcessor();

            var request = new TicketBookingRequest
            {
                FirstName = "Ali",
                LastName = "Ebrahimi",
                Email = "a.ebrahimi1367@gmail.com"
            };
            #endregion

            #region Act
            TicketBookingResponse response = processor.Book(request);
            #endregion

            #region Assert
            Assert.NotNull(response);
            Assert.Equal(request.FirstName, response.FirstName);
            Assert.Equal(request.LastName, response.LastName);
            Assert.Equal(request.Email, response.Email);
            #endregion
        }
    }
}

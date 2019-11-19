using Xunit;

namespace UserService.test
{
    public class UserService__ConnectSuccesFull
    {
        private readonly DBConnect _dbConnect;

        public UserService__ConnectSuccesFull()
        {
            _dbConnect = new DBConnect();
        }
            
        [Fact]
        public void ConnectToDB_CanConnect_returnTrue()
        {
            var result = _dbConnect.ConnectToDB();
            Assert.True(result, "can't connect to db!");
        }
    }
}
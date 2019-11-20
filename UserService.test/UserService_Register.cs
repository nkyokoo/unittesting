using Xunit;

namespace UserService.test
{
    public class UserService_Register
    {
        
        private readonly UserServices _userServices;

        public UserService_Register()
        {
            _userServices = new UserServices();
        }
            
        [Theory]
        [InlineData("user1","user1@example.com", "1234")]
        [InlineData("user2","user2@example.com", "1234")]
        public void login_returnTrue(string username, string email, string password)
        { 
            var result = _userServices.Register(username,email,password);
            Assert.True(result, "login fail");
        }
    }
}
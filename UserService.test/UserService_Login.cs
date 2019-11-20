using Xunit;
using Newtonsoft.Json;

namespace UserService.test
{
    public class UserService_Login
    {
        private readonly UserServices _userServices;

        public UserService_Login()
        {
            _userServices = new UserServices();
        }
            
        [Theory]
        [InlineData("user1@example.com", "1234")]
        [InlineData("user2@example.com", "1234")]
        public void login_returnTrue(string email, string password)
        { 
            var result = _userServices.Login(email,password);
            Assert.True(result, "login fail");
        }
    }
}
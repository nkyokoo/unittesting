using Xunit;
using UserService;

namespace UserService.test
{
    public class UserService_isUser
    {
        private readonly UserServices _userServices;

        public UserService_isUser()
        {
            _userServices = new UserServices();
        }
            
        [Theory]
        [InlineData("user@example.com")]
        [InlineData("a@example.l.ll")]
        [InlineData("b@example.d.c.dd")]
        public void isValidEmail_EmailIsValid_returnTrue(string value)
        { 
             var result = _userServices.IsValidEmail(value);
             Assert.True(result, "Email is not valid");
        }
    }
}
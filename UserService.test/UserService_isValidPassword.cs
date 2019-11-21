using Xunit;

namespace UserService.test
{
    public class UserService_isValidPassword
    {
        private readonly UserServices _userServices;

        public UserService_isValidPassword()
        {
            _userServices = new UserServices();
        }
            
        [Theory]
        [InlineData("aSf2?s2")]
        [InlineData("5Sf2?w2")]
        [InlineData("fSf2?w2")]
        public void isValidPassword_PasswordIsValid_returnTrue(string value)
        { 
            var result = _userServices.isValidPassword(value);
            Assert.True(result, "Password is not valid");
        }
        
    }
} 
using Xunit;

namespace UserService.test
{
    public class UserService_DataConstructor
    {
        private readonly DataConstructor _constructor;

        public UserService_DataConstructor()
        {
            _constructor = new DataConstructor();
        }
            
        [Fact]
        public void ConvertCarData_CanConvert_returnTrue()
        {
            var result = _constructor.ConvertCarData();
            Assert.True(result, "conversion failed!");
        }
        [Fact]
        public void ConvertUserData_CanConvert_returnTrue()
        {
            var result = _constructor.ConvertUser();
            Assert.True(result, "conversion failed!");
        }
    }
}
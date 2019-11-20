using Xunit;

namespace UserService.test
{
    public class DatabasesServices
    {
        private readonly DatabaseServices databaseServices;

        public DatabasesServices()
        {
            databaseServices = new DatabaseServices();
        }
            
        [Fact]
        public void GetCarData_CanGetData_returnTrue()
        { 
            var result = databaseServices.GetCars();
            Assert.True(result, "failed getting data");
        } 
        [Fact]
        public void GetUserData_CanUserData_returnTrue()
        { 
            var result = databaseServices.GetUsers();
            Assert.True(result, "failed getting data");
        } 
    }
    
}
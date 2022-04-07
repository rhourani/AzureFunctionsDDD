using AzureFunctionsDDD.Cosmos.Dto.Customers;
using AzureFunctionsDDD.Cosmos.Services.GreetingService;
using System;
using Xunit;

namespace AzureFucntionsDDD.TEST
{
    public class GetCustomerFullNameTest
    {
        //private readonly GreetingService _greetingService;

        public GetCustomerFullNameTest(/*IGreetingService greetingService*/)
        {
            //_greetingService = greetingService;
        }


        [Fact]
        public void Test1()
        {
            CustomerDTO expected = new CustomerDTO
            {
              FirstName = "Ridvan",
                FullName = "Ridvan Alhourani",
              LastName = "Alhourani"
              
            };
            GreetingService greetingService = new(null,null);
            var result  = greetingService.FullName(new CustomerDTO { FirstName = "Ridvan", LastName = "Alhourani" });

            Assert.Equal(expected, result);//will return false since this compare by objs by refernce..
        }
    }
}

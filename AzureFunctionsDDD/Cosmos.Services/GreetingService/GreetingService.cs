namespace AzureFunctionsDDD.Cosmos.Services.GreetingService
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _logger;
        private readonly IMapper _mapper;
        public GreetingService(
            ILogger<GreetingService> logger,
            IMapper mapper
            )
        {
            _logger = logger;
            _mapper = mapper;
        }
        public CustomerDTO FullName(CustomerDTO customerDTO)
        {
            customerDTO.FullName = customerDTO.FirstName + " " + customerDTO.LastName;
            return customerDTO;
        }
    }
}

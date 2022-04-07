namespace AzureFunctionsDDD
{
    public class GetCustomerName
    {

        #region params
        private readonly IGreetingService _greetingService;
        private readonly ILogger<GetCustomerName> _logger;
        private readonly IMapper _mapper;
        #endregion

        #region cst
        public GetCustomerName(
            IGreetingService greetingService,
            ILogger<GetCustomerName> logger,
            IMapper mapper)
        {
            _greetingService = greetingService;
            _logger = logger;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        [FunctionName("GetCustomerName")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            CustomerDTO customerDTO = JsonConvert.DeserializeObject<CustomerDTO>(requestBody);

            customerDTO = _greetingService.FullName(customerDTO);

            return new OkObjectResult(customerDTO);
        }
        #endregion
    }
}

using API_REST.Services;
using Microsoft.AspNetCore.Mvc;


namespace API_REST.Controllers
{
    [ApiController]
    [Route("api/request")]
    public class RequestsController : ControllerBase
    {
        private readonly IRequestRepository _requestRepository;

        public RequestsController(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        [HttpGet("{i:int}/{n:int}/{name}")]
        public async Task<ActionResult<IEnumerable<int>>> CalculatePrimes(int i, int n, string name)
        {
            var calculatePrimes = new RequestService().CalculationPrimeNumbers(i, n, name);
            
            //! PATRON REPOSITORIO (PATTERN REPOSITORY)
            await _requestRepository.SaveRequests(i, n, calculatePrimes, name);

            //Retorna una respuesta HTTP con la lista 
            return Ok(calculatePrimes);
        }
    }
}

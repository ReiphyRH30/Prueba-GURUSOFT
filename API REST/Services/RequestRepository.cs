using API_REST.Entities;
using System.Text.Json;

namespace API_REST.Services
{
    //PATRON REPOSITORIO (PATTERN REPOSITORY)

    public interface IRequestRepository
    {
        Task SaveRequests(int i, int n, List<int> prime, string name);
    }

    public class RequestRepository : IRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public RequestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveRequests(int i, int n, List<int> prime, string name)
        {
            //se crea un objeto de tipo peticion
            var query = new Query()
            {
                Usuario = name,
                Request = $"i={i}, n={n}",
                FechaRequest = DateTime.Now,
                Response = JsonSerializer.Serialize(prime),
                FechaResponse = DateTime.Now
            };

            //Se guarda en la base de datos con EntityFramework
            await _context.Queries.AddAsync(query);
            await _context.SaveChangesAsync();
        }
    }
}

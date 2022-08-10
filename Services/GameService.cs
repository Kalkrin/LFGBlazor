namespace LFGWebApp 
{
    public class GameService
    {
        private readonly HttpClient _http;

        public GameService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ServiceResponse<List<PublicGameDto>>> GetAllGames()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<PublicGameDto>>>($"Game");
            return result;
        }

        public async Task<ServiceResponse<PublicGameDto>> CreateGame(AddGameDto request)
        {
            var result = await _http.PostAsJsonAsync($"Game", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<PublicGameDto>>();
        }

        public async Task<ServiceResponse<int>> DeleteGame(int id)
        {
            var result = await _http.DeleteAsync($"Game/DeleteGame/{id}");
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
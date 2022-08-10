namespace LFGWebApp
{
    public class UserService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ServiceResponse<List<User>>> GetUsers()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<User>>>($"User");
            return result;
        }

        public async Task<ServiceResponse<PublicUserDto>> GetUserById(int id)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<PublicUserDto>>($"User/GetById/{id}");
            return result;
        }

        public async Task<ServiceResponse<PublicUserDto>> UpdateUser(int id, UpdateUserDto request)
        {
            var result = await _http.PutAsJsonAsync($"User/UpdateUser/{id}", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<PublicUserDto>>();
        }

        public async Task<ServiceResponse<PublicUserDto>> UpdateUserPassword(int id, UpdateUserPasswordDto request)
        {
            var result = await _http.PutAsJsonAsync($"User/UpdateUserPassword/{id}", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<PublicUserDto>>();
        }
    }
}
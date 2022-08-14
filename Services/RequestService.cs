namespace LFGWebApp
{
    public class RequestService
    {
        private readonly HttpClient _http;

        public RequestService(HttpClient http)
        {
            _http = http;
        }

        public int Count { get; set; } = 0;

        public event Action OnCountChange;

        public void SetCount(int count)
        {
            Count = count;
            OnCountChange?.Invoke();
        }

        public void IncreaseCount()
        {
            Count++;
            OnCountChange?.Invoke();
        }

        public void DecreaseCount()
        {
            Count--;
            OnCountChange?.Invoke();
        }

        public void RefreshCount()
        {
            OnCountChange?.Invoke();
        }

        public async Task<ServiceResponse<List<PublicRequestDto>>> GetRequestByUserId(int userId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<PublicRequestDto>>>($"Request/GetRequestsByUserId/{userId}");
            return result;
        }
        public async Task<ServiceResponse<List<PublicRequestDto>>> GetRequestForCreator(int userId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<PublicRequestDto>>>($"Request/GetRequestsForCreator/{userId}");
            return result;
        }
        public async Task<ServiceResponse<PublicRequestDto>> CreateRequest(AddRequestDto request)
        {
            var result = await _http.PostAsJsonAsync($"Request", request);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<PublicRequestDto>>();
        }

        public async Task<ServiceResponse<PublicRequestDto>> ApproveDenyRequest(AcceptDeclineRequestDto ad, int requestId)
        {
            var result = await _http.PutAsJsonAsync($"Request/ApproveOrDenyRequest/{requestId}", ad);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<PublicRequestDto>>();
        }
    }
}

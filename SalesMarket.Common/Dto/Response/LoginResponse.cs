namespace SalesMarket.Common.Dto.Response
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public LoginResponse(bool success) { this.Success = success; }
    }
}

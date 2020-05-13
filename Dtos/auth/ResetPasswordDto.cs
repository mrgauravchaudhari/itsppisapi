namespace cfclapi.Dtos
{
    public class ResetPasswordDto
    {
        public string username { get; set; }
        public string temppassword { get; set; }
        public string newpassword { get; set; }
    }
}

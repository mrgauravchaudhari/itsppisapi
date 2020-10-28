namespace itsppisapi.Models
{
    public class UserProfile
    {
        public decimal USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string ACTIVE_FLAG { get; set; }
        public byte[] PASSWORD_HASH { get; set; }
        public byte[] PASSWORD_SALT { get; set; }
    }
}

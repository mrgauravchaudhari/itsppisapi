namespace itsppisapi.Dtos
{
    public class PGS010SaveDto
    {
        public decimal USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_DESC { get; set; }
        public decimal USER_LEVEL { get; set; }
        public string USER_DEPT { get; set; }
        public decimal USER_EPR_NO { get; set; }
        public string USER_PHONE_NO { get; set; }
        public string USER_EMAIL { get; set; }
        public string ACTIVE_FLAG { get; set; }
        public string USER_VALIDITY_DT { get; set; }
        public decimal ENTERED_BY { get; set; }
        public decimal MODIFIED_BY { get; set; }
    }
}

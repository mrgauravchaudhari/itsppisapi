namespace itsppisapi.Models
{
    public class PGS013Model
    {
        public decimal GROUP_ID { get; set; }
        public string GROUP_MODULES { get; set; }
    }
    public class ListAccessModuleModel
    {
        // public decimal GROUP_ID { get; set; }
        public string MODULE_GROUP { get; set; }
        public decimal USER_ID { get; set; }
        public string ACCESS_FLAG { get; set; }
        public string GROUP_MODULES { get; set; }
    }
    public class ListModuleModel
    {
        public decimal MODULE_ID { get; set; }
        public string MODULE_NAME { get; set; }
        public string MODULE_DESC { get; set; }
    }
    public class ListGroupModel
    {
        public decimal GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
    }
    public class ListGroupsByUser
    {
        public decimal GROUP_ID { get; set; }
    }
}

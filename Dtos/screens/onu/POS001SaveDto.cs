namespace itsppisapi.SaveDtos
{
    public class MachineMasterSaveDto
    {
        public string OU_DEPT_CODE { get; set; }
        public string OU_UNIT_ID { get; set; }
        public string OU_MACH_NAME { get; set; }
        public string OU_MACH_DESC { get; set; }
        public string OU_CATG_NAME { get; set; }
        public string OU_PUMP_UNIT_FLG { get; set; }
        public string OU_MACH_ASSOCIATION { get; set; }
        public decimal OU_USER_ID { get; set; }
        public string OU_MACH_ACTIVE_FLAG { get; set; }
    }

    public class  ChemicalMasterSaveDto
    {
        public string OU_CHEMICAL_ID { get; set; }
        public string OU_MEAS_UNIT { get; set; }
        public decimal OU_TANK_NO { get; set; }
        public string OU_CHEMICAL_NAME { get; set; }
        public string OU_DEPT_CODE { get; set; }
        public decimal OU_USER_ID { get; set; }
    }

    public class StockMasterSaveDto
    {
        public string OU_CHEMICAL_ID { get; set; }
        public decimal OU_CHEMICAL_LEVEL { get; set; }
        public decimal OU_CHEMICAL_STOCK { get; set; }
        public decimal OU_USER_ID { get; set; }
    }
}

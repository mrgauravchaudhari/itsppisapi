namespace cfclapi.Models
{
  public class ModuleMasterModel
  {
    public string MODULE_NAME { get; set; }
    public string MODULE_DESC { get; set; }
    public string MODULE_TYPE { get; set; }
    public decimal USER_ID { get; set; }
    public string PARENT_MODULE_NAME { get; set; }
    public string LONG_DESC { get; set; }
    public string DEPT_CODE { get; set; }
    public string FREQUENCY { get; set; }
    public decimal MOD_LEVEL { get; set; }
    public decimal NO_PAGES { get; set; }
    public string FORM_NAME { get; set; }
    public string UNIT_ID { get; set; }
    public string ACTIVE_FLG { get; set; }
  }
}

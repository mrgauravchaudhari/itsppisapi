namespace itsppisapi.Models
{
    public class PAS211Model
    {
        public string MINDT { get; set; }
        public string MAXDT { get; set; }
        public string OU1_TRANS_DATE { get; set; }
        public string OU1_UNIT_ID { get; set; }
        public string OU1_DATE_MOD { get; set; }
        public dynamic OU1_USER_ID { get; set; }
        public string OU1_USER_NAME { get; set; }

        public decimal OU1_ACT_CIRC_FLOW { get; set; }
        public decimal OU1_ACT_MAKE_UP { get; set; }
        public decimal OU1_ACT_SUPP_TEMP { get; set; }
        public decimal OU1_ACT_RETN_TEMP { get; set; }
        public decimal OU1_ACT_DRYBULB_TEMP { get; set; }
        public decimal OU1_ACT_WETBULB_TEMP { get; set; }
        public decimal OU1_ACT_APPWACH { get; set; }
        public decimal OU1_ACT_RANGE { get; set; }
        public decimal OU1_ACT_HEAT_DUTY { get; set; }
        public decimal OU1_ACT_THERMAL_EFF { get; set; }
        public decimal OU1_UCT_CIRC_FLOW { get; set; }
        public decimal OU1_UCT_MAKE_UP { get; set; }
        public decimal OU1_UCT_SUPP_TEMP { get; set; }
        public decimal OU1_UCT_RETN_TEMP { get; set; }
        public decimal OU1_UCT_DRYBULB_TEMP { get; set; }
        public decimal OU1_UCT_WETBULB_TEMP { get; set; }
        public decimal OU1_UCT_APPWACH { get; set; }
        public decimal OU1_UCT_RANGE { get; set; }
        public decimal OU1_UCT_HEAT_DUTY { get; set; }
        public decimal OU1_UCT_THERMAL_EFF { get; set; }

        // --------------------------PRV-------------------------------
        public string PRV_OU_TRANS_DATE { get; set; }
        public decimal PRV_OU_ACT_CIRC_FLOW { get; set; }
        public decimal PRV_OU_ACT_MAKE_UP { get; set; }
        public decimal PRV_OU_ACT_SUPP_TEMP { get; set; }
        public decimal PRV_OU_ACT_RETN_TEMP { get; set; }
        public decimal PRV_OU_ACT_DRYBULB_TEMP { get; set; }
        public decimal PRV_OU_ACT_WETBULB_TEMP { get; set; }
        public decimal PRV_OU_UCT_CIRC_FLOW { get; set; }
        public decimal PRV_OU_UCT_MAKE_UP { get; set; }
        public decimal PRV_OU_UCT_SUPP_TEMP { get; set; }
        public decimal PRV_OU_UCT_RETN_TEMP { get; set; }
        public decimal PRV_OU_UCT_DRYBULB_TEMP { get; set; }
        public decimal PRV_OU_UCT_WETBULB_TEMP { get; set; }
    }
}

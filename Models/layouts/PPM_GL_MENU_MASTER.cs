using System.ComponentModel.DataAnnotations;
namespace cfclapi.Models
{
    public class PPM_GL_MENU_MASTER
    {
        [Key]
        public string MODULE_NAME { get; set; }
        public string MODULE_DESC { get; set; }
        public string MODULE_URL { get; set; }
        public string PARENT_MODULE_NAME { get; set; }	
    
    }
}
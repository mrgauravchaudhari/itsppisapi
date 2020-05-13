using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace itsppisapi.Models
{
    [Table("PPM_GL_MODULE", Schema="PPIS")]
    public partial class PPV_TREEMENU
    {
        public string MODULE_NAME { get; set; }
        public string MODULE_DESC { get; set; }
        public string MODULE_TYPE { get; set; }
        public string ROUTE_LINK { get; set; }
        public string PARENT_MODULE_NAME { get; set; }
        public List<PPV_TREEMENU> Categories { get; set; }
        public PPV_TREEMENU()
        {
            Categories = new List<PPV_TREEMENU>();
        }
    }
}
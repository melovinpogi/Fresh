using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreshPros.Commons.Objects.Crew
{
    [Table("crew_equipments")]
    public class CrewEquipments
    {
        [Key]
        public long id { get; set; }
        public int? crew_id { get; set; }
        public int? crew_equipment_type { get; set; }
        public string note { get; set; }
    }
}
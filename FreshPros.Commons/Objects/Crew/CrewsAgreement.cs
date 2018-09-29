using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreshPros.Commons.Objects.Crew
{
    [Table("crew_agreement")]
    public class CrewsAgreement
    {
        [Key]
        public long id { get; set; }
        public int? day { get; set; }
        public string month { get; set; }
        public int? year { get; set; }
        public string individual_company_name { get; set; }
        public string contact_person { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        public string tel_no { get; set; }
        public string cell_no { get; set; }
        public string alt_contact_phone_or_person { get; set; }
        public string id_number { get; set; }
        public string id_type { get; set; }
        public bool cb_signature { get; set; }
        public string printed_name { get; set; }
        public DateTime? date { get; set; }
        public string crew_signature { get; set; }
        public int? crew_id { get; set; }
    }
}
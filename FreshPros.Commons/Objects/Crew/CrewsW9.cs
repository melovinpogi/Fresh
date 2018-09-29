using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FreshPros.Commons.Objects.Crew
{
    [Table("crew_w9")]
    public class CrewsW9
    {
        [Key]
        public long id { get; set; }
        public int? crew_id { get; set; }
        public string name { get; set; }
        public string business_name { get; set; }
        public string tax_classification { get; set; }
        public string tax_classification_note { get; set; }
        public string exemptions_payee_code { get; set; }
        public string exemptions_from_fatca_code { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string requester_name_address { get; set; }
        public string list_account_number { get; set; }
        public string ssn { get; set; }
        public string ein { get; set; }
        public DateTime? date { get; set; }
        public string signature { get; set; }
        public bool cb_signature { get; set; }
    }
}
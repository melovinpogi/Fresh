using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreshPros.Commons.Objects.Crew
{
    [Table("crew_reg")]
    public class Crews
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string crew_code { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public int? status { get; set; }
        public string lastname { get; set; }
        public int? updated { get; set; }
        public string color_pin { get; set; }
        public string PhoneType { get; set; }
        public bool is_full_time { get; set; }
        public bool have_crews { get; set; }
        public int? no_of_crews { get; set; }
        public string profile_picture { get; set; }
        public DateTime? date_submit { get; set; }
        public int? accepted_by { get; set; }
        public string note { get; set; }
        public bool mon { get; set; }
        public bool tue { get; set; }
        public bool wed { get; set; }
        public bool thu { get; set; }
        public bool fri { get; set; }
        public bool sat { get; set; }
        public DateTime? date_start { get; set; }
        public int? num_of_jobs { get; set; }
        public string device_id { get; set; }
        public int avg_jobs { get; set; }
        public bool? have_business_insurance { get; set; }
        public int? no_of_trucks { get; set; }
        public decimal rate_percentage { get; set; }
        public bool? is_removed { get; set; }
        public string lng { get; set; }
        public string lat { get; set; }
        public int? added_by { get; set; }
        public string zipcodes { get; set; }
        public bool isSpecialCrew { get; set; }
    }
}
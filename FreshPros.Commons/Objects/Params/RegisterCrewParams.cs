using FreshPros.Commons.Objects.Crew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FreshPros.Commons.Objects.Params
{
    public class RegisterCrewParams
    {
        public Crews crew { get; set; }
        public int[] crewEq { get; set; }
    }
}
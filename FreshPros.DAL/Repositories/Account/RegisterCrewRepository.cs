using FreshPros.Commons.Helpers;
using FreshPros.Commons.Objects.Crew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using FreshPros.Commons.Objects.Params;
using FreshPros.Commons.Interfaces.Crew;

namespace FreshPros.DAL.Repositories.Account
{
    public class RegisterCrewRepository : GenericRepository<Crews>, IRegisterCrewRepository
    {
        public RegisterCrewRepository()
        {
            
        }

        public void processRegister(RegisterCrewParams param)
        {
            long crewID = register(param.crew);
            if (crewID > 0)
            {
                saveEQ(param.crewEq, crewID);
            }
        }
        public long register(Crews param)
        {
            string pw = UtilsHelper.base64Encode("freshlawn");

            string crewCode = param.name + " " + param.lastname;
            crewCode = crewCode.Substring(0, 10);

            int countCode = crewCodeExist(crewCode);

            string newCode = countCode > 0 ? crewCode + "" + countCode.ToString() : crewCode;
            Crews crew = new Crews
            {
                name = param.name,
                lastname = param.lastname,
                password = pw,
                phone = param.phone,
                crew_code = newCode,
                address = param.address,
                city = param.city,
                state = param.state,
                zipcode = param.zipcode,
                status = 5,
                updated = 1,
                color_pin = "#808080",
                PhoneType = param.PhoneType,
                is_full_time = param.is_full_time,
                have_crews = param.have_crews,
                no_of_crews = param.no_of_crews,
                date_submit = DateTime.Now,
                mon = param.mon,
                tue = param.tue,
                wed = param.wed,
                thu = param.thu,
                fri = param.fri,
                sat = param.sat,
                date_start = param.date_start,
                num_of_jobs = param.num_of_jobs,
                lng = param.lng,
                lat = param.lat,
                zipcodes = param.zipcode
            };

            return InsertRecord(crew);
        }

        public void saveEQ(int[] param,long crewID)
        {
            if (param.Length > 0)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    CrewEquipments eq = new CrewEquipments
                    {
                        crew_id = (int)crewID,
                        crew_equipment_type = param[i],
                        note = String.Empty
                    };

                    _db.Insert(eq);
                }
            }
            
        }
        public void saveW9(CrewsW9 param)
        {
            CrewsW9 w9 = new CrewsW9
            {
                crew_id = param.crew_id,
                name = param.name,
                business_name = param.business_name,
                tax_classification= param.tax_classification,
                tax_classification_note = param.tax_classification_note,
                exemptions_from_fatca_code = param.exemptions_from_fatca_code,
                exemptions_payee_code = param.exemptions_payee_code,
                address = param.address,
                city = param.city,
                state = param.city,
                zip = param.zip,
                requester_name_address = param.requester_name_address,
                list_account_number = param.list_account_number,               
                date = param.date,
            };
            _db.Insert(w9);
        }


        public void saveAgreement(CrewsAgreement param)
        {
            CrewsAgreement ag = new CrewsAgreement
            {
                day = param.day,
                month = param.month,
                year = param.year,
                individual_company_name = param.individual_company_name,
                contact_person = param.contact_person,
                address = param.address,
                city = param.city,
                state = param.state,
                zip = param.zip,
                email = param.email,
                tel_no = param.tel_no,
                cell_no = param.cell_no,
                alt_contact_phone_or_person = param.alt_contact_phone_or_person,
                id_number = param.id_number,
                id_type = param.id_type,
                printed_name = param.printed_name,
                date = param.date,
                crew_id = param.crew_id
            };
            _db.Insert(ag);
        } 

        public int updateProfile(Crews param)
        {
            return _db.Execute("UPDATE crew_reg SET profile_picture = @pp WHERE id = @id", new { pp = param.profile_picture, id = param.id });
        }

        private int crewCodeExist(string crewCode)
        {
            int count = _db.RecordCount<Crews>("WHERE ltrim(rtrim(crew_code)) = ltrim(rtrim(@code))", new { code = crewCode });
            if(count > 0)
            {
                return count + 1;
            }
            else
            {
                return 0;
            }           
        }
    }
}

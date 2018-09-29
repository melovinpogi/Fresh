using FreshPros.Commons.Objects.Crew;
using FreshPros.Commons.Objects.Params;

namespace FreshPros.Commons.Interfaces.Crew
{
    public interface IRegisterCrewRepository
    {
        void processRegister(RegisterCrewParams param);
        long register(Crews param);
        void saveAgreement(CrewsAgreement param);
        void saveEQ(int[] param, long crewID);
        void saveW9(CrewsW9 param);
        int updateProfile(Crews param);
    }
}
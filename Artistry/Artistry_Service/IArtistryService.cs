using System.ServiceModel;

namespace Artistry_Service
{
    [ServiceContract]
    public interface IArtistryService
    {
        [OperationContract]
        Artistry_CL.classlistfiles.GenderList GetGenderInfo();

        [OperationContract]
        void AddGender(string genderDescription);

        [OperationContract]
        void UpdateGender(int id, string genderDescription);

        [OperationContract]
        void DeleteGender(int id, string genderDescription);
    }    
}

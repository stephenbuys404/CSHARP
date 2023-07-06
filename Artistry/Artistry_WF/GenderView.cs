using System.Windows.Forms;

namespace Artistry_WF
{
    public partial class GenderView : Form
    {
        ServiceReference1.ArtistryServiceClient genderService;    
        
        public GenderView()
        {
            InitializeComponent();
            genderService = new ServiceReference1.ArtistryServiceClient();            
            dvgGenders.DataSource = genderService.GetGenderInfo();
        }
    }
}

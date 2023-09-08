using Datalus.Core;
using Datalus.Core.Controllers;
using ReaLTaiizor.Forms;

namespace Datalus
{
    public partial class MainForm : CrownForm, IHasStatusText
    {
        public MainForm()
        {
            // initialize form
            InitializeComponent();

            // set this as the status text object
            StatusController.TextObject = this;
        }

        public string StatusText
        {
            get => MyStatusText.Text;
            set => MyStatusText.Text = value;
        }

        private void OnFormLoad(object sender, System.EventArgs e)
        {
            // set ready status
            StatusController.Ready();
        }
    }
}

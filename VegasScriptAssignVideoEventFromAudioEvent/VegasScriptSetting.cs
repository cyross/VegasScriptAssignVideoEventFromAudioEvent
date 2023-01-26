using System.Windows.Forms;

namespace VegasScriptAssignVideoEventFromAudioEvent
{
    public partial class VegasScriptSettingDialog : Form
    {
        public VegasScriptSettingDialog()
        {
            InitializeComponent();
        }

        public string JimakuTrackTitle
        {
            get { return searchWord.Text; }
            set { searchWord.Text = value; }
        }

        public double JimakuMargin
        {
            get { return double.Parse(marginBox.Text); }
            set { marginBox.Text = value.ToString(); }
        }
    }
}

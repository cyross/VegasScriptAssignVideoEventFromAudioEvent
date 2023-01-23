using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VegasScriptAssignVideoEventFromAudioEvent
{
    public partial class VegasScriptSettingDialog : Form
    {
        public VegasScriptSettingDialog()
        {
            InitializeComponent();
        }

        public string SearchTrackName
        {
            get { return searchTrackNameBox.Text; }
            set { searchTrackNameBox.Text = value; }
        }

        public double JimakuMargin
        {
            get { return double.Parse(marginBox.Text); }
            set { marginBox.Text = value.ToString(); }
        }
    }
}

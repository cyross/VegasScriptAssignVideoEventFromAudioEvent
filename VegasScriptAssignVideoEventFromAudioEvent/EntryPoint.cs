using ScriptPortal.Vegas;
using System.Drawing;
using System.Windows.Forms;

namespace VegasScriptAssignVideoEventFromAudioEvent
{
    public class EntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            VegasScriptSettings.Load();
            VegasHelper helper = VegasHelper.Instance(vegas);

            VegasScriptSettingDialog dialog = new VegasScriptSettingDialog();
            dialog.SearchTrackName = VegasScriptSettings.TargetAssignTrackName;
            dialog.JimakuMargin = VegasScriptSettings.AssignEventMargin;
            
            if(dialog.ShowDialog() == DialogResult.OK )
            {
                string searchName = dialog.SearchTrackName;
                double margin = dialog.JimakuMargin;

                helper.AssignAudioTrackDurationToVideoTrack(searchName, margin);

                VegasScriptSettings.TargetAssignTrackName = searchName;
                VegasScriptSettings.AssignEventMargin = margin;
                VegasScriptSettings.Save();
            }
        }
    }
}

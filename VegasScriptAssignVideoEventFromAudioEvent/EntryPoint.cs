using ScriptPortal.Vegas;
using VegasScriptHelper;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace VegasScriptAssignVideoEventFromAudioEvent
{
    public class EntryPoint: IEntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            VegasHelper helper = VegasHelper.Instance(vegas);

            // コンボボックッスの既定値の優先度:
            // 1)選択したトラック
            // 2)指定の名前のトラック
            // 3)最初のトラック
            Dictionary<string, VideoTrack> videoKeyValuePairs = helper.GetVideoKeyValuePairs();
            List<string> videoKeyList = videoKeyValuePairs.Keys.ToList();

            if (!videoKeyList.Any())
            {
                MessageBox.Show("ビデオトラックがありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, AudioTrack> audioKeyValuePairs = helper.GetAudioKeyValuePairs();
            List<string> audioKeyList = audioKeyValuePairs.Keys.ToList();

            if (!audioKeyList.Any())
            {
                MessageBox.Show("オーディオトラックがありません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VideoTrack targetVideoTrack = helper.SelectedVideoTrack(false);

            if(targetVideoTrack == null) {
                targetVideoTrack = helper.SearchVideoTrackByName(VegasScriptSettings.TargetAssignTrackName);
            }

            string videoTrackKey = targetVideoTrack != null ? helper.GetTrackKey(targetVideoTrack) : videoKeyList[0];

            AudioTrack targetAudioTrack = helper.SelectedAudioTrack(false);

            if (targetAudioTrack == null)
            {
                targetAudioTrack = helper.SearchAudioTrackByName(VegasScriptSettings.TargetAssignTrackName);
            }

            string audioTrackKey = targetAudioTrack != null ? helper.GetTrackKey(targetAudioTrack) : audioKeyList[0];

            try
            {
                VegasScriptSettingDialog dialog = new VegasScriptSettingDialog()
                {
                    VoiceTrackNameDataSource = audioKeyList,
                    VoiceTrackName = audioTrackKey,
                    JimakuTrackNameDataSource = videoKeyList,
                    JimakuTrackName = videoTrackKey,
                    JimakuMargin = VegasScriptSettings.AssignEventMargin
                };

                if (dialog.ShowDialog() == DialogResult.Cancel) { return; }

                VideoTrack videoTrack = videoKeyValuePairs[dialog.JimakuTrackName];
                AudioTrack audioTrack = audioKeyValuePairs[dialog.VoiceTrackName];
                double margin = dialog.JimakuMargin;

                helper.AssignAudioTrackDurationToVideoTrack(videoTrack, audioTrack, margin);

                VegasScriptSettings.AssignEventMargin = margin;
                VegasScriptSettings.Save();
            }
            catch (VegasHelperTrackUnselectedException)
            {
                MessageBox.Show("ビデオトラックが選択されていません。");
            }
            catch (VegasHelperNoneEventsException)
            {
                MessageBox.Show("選択したビデオトラック中にイベントが存在していません。");
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using MTFrame.MTEvent;
using UnityEngine.UI;
using RenderHeads.Media.AVProVideo;

public class UsagePanel : BasePanel
{
    public Button BackButton;

    public MediaPlayer mediaPlayer;

    public override void InitFind()
    {
        base.InitFind();
        BackButton = FindTool.FindChildComponent<Button>(transform, "backButton");

        mediaPlayer = FindTool.FindChildComponent<MediaPlayer>(transform, "VideoBG/Video Player/Video Player");
    }

    public override void InitEvent()
    {
        base.InitEvent();
        BackButton.onClick.AddListener(() => {
            GenLuBuState.SwitchPanel(PanelName.CatalogPanel);
        });
    }

    public override void Open()
    {
        base.Open();
        mediaPlayer.OpenVideoFromFile(MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, "AVProVideoSamples/DA-5-更路簿查询.mp4");
    }

    public override void Hide()
    {
        base.Hide();
        mediaPlayer.Control.Stop();
    }
}

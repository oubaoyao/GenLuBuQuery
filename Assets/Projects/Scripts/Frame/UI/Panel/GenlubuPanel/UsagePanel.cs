using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using MTFrame.MTEvent;
using UnityEngine.UI;

public class UsagePanel : BasePanel
{
    public Button BackButton;

    public override void InitFind()
    {
        base.InitFind();
        BackButton = FindTool.FindChildComponent<Button>(transform, "backButton");
    }

    public override void InitEvent()
    {
        base.InitEvent();
        BackButton.onClick.AddListener(() => {
            GenLuBuState.SwitchPanel(PanelName.CatalogPanel);
        });
    }

}

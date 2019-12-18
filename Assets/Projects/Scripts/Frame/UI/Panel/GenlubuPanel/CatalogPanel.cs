using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using MTFrame.MTEvent;
using UnityEngine.UI;

public class CatalogPanel : BasePanel
{
    public Button[] buttons; 

    public override void InitFind()
    {
        base.InitFind();
        buttons = GetComponentsInChildren<Button>();
    }

    public override void InitEvent()
    {
        base.InitEvent();
        buttons[0].onClick.AddListener(() => {
            GenLuBuState.SwitchPanel(PanelName.QueryPanel);
        });

        buttons[1].onClick.AddListener(() => {
            GenLuBuState.SwitchPanel(PanelName.UsagePanel);
        });

        buttons[2].onClick.AddListener(() => {
            GenLuBuState.SwitchPanel(PanelName.WaitPanel);
        });
    }

    public override void Open()
    {
        base.Open();
    }

    public override void Hide()
    {
        base.Hide();
    }
}

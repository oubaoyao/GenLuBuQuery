using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using MTFrame.MTEvent;
using UnityEngine.UI;

public class WaitPanel : BasePanel
{
    public Button button;

    public override void InitFind()
    {
        base.InitFind();
        button = FindTool.FindChildComponent<Button>(transform, "Image");
    }

    public override void InitEvent()
    {
        base.InitEvent();
        button.onClick.AddListener(()=>{
            GenLuBuState.SwitchPanel(PanelName.CatalogPanel);
            BGPanel.Instance.ShipHide();
        });
    }

    public override void Open()
    {
        base.Open();
        BGPanel.Instance.ShipOpen();
    }
}

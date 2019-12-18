using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using MTFrame.MTEvent;
using UnityEngine.UI;

public class WaitPanel : BasePanel
{
    public Button button;

    private float Time = 5.0f;

    public override void InitFind()
    {
        base.InitFind();
        button = FindTool.FindChildComponent<Button>(transform, "bg");
    }

    public override void InitEvent()
    {
        base.InitEvent();
        button.onClick.AddListener(()=>{
            GenLuBuState.SwitchPanel(PanelName.CatalogPanel);
        });
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        TimeTool.Instance.Remove(TimeDownType.NoUnityTimeLineImpact, () => {
            GenLuBuState.SwitchPanel(PanelName.WaitPanel);
        });
    }
}

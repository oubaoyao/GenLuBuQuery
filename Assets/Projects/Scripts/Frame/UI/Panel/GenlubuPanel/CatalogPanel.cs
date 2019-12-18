using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using MTFrame.MTEvent;
using UnityEngine.UI;
using System;

public class CatalogPanel : BasePanel
{
    public Button[] buttons;

    private float Time = 120.0f;

    protected override void Awake()
    {
        base.Awake();
        TimeTool.Instance.AddDelayed(TimeDownType.NoUnityTimeLineImpact, Time, ReturnWaitPanel);
    }

    public override void InitFind()
    {
        base.InitFind();
        buttons = GetComponentsInChildren<Button>();
    }

    public override void InitEvent()
    {
        base.InitEvent();
        buttons[0].onClick.AddListener(() => {
            GenLuBuState.SwitchPanel(PanelName.UsagePanel);
        });

        buttons[1].onClick.AddListener(() => {
            GenLuBuState.SwitchPanel(PanelName.QueryPanel);
        });

        buttons[2].onClick.AddListener(() => {
            GenLuBuState.SwitchPanel(PanelName.WaitPanel);
        });
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            TimeTool.Instance.Remove(TimeDownType.NoUnityTimeLineImpact, ReturnWaitPanel);
            TimeTool.Instance.AddDelayed(TimeDownType.NoUnityTimeLineImpact, Time, ReturnWaitPanel);
        }

        if (Input.GetMouseButtonDown(0))
        {
            TimeTool.Instance.Remove(TimeDownType.NoUnityTimeLineImpact, ReturnWaitPanel);
        }
    }

    private void ReturnWaitPanel()
    {
        GenLuBuState.SwitchPanel(PanelName.WaitPanel);
    }
}

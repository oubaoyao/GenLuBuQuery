using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using MTFrame.MTEvent;

public enum PanelSwitch
{
    StateToPanel,
    PanelToState,
}

public enum PanelName
{
    WaitPanel,
    CatalogPanel,
    UsagePanel,
    QueryPanel,
}

public class GenLuBuState : BaseState
{
    public override string[] ListenerMessageID {
        get {
            return new string[]
            {
                PanelSwitch.PanelToState.ToString(),
            };

        }
        set
        {
        }
    }

    public override void OnListenerMessage(EventParamete parameteData)
    {
        if(parameteData.EvendName == PanelSwitch.PanelToState.ToString())
        {
            PanelName panelName = parameteData.GetParameter<PanelName>()[0];
            switch (panelName)
            {
                case PanelName.WaitPanel:
                    CurrentTask.ChangeTask(new WaitTask(this));
                    break;
                case PanelName.CatalogPanel:
                    CurrentTask.ChangeTask(new CatalogTask(this));
                    break;
                case PanelName.UsagePanel:
                    CurrentTask.ChangeTask(new UsageTask(this));
                    break;
                case PanelName.QueryPanel:
                    CurrentTask.ChangeTask(new QueryTask(this));
                    break;
                default:
                    break;
            }
        }
    }

    public override void Enter()
    {
        base.Enter();
        CurrentTask.ChangeTask(new WaitTask(this));
    }

    public static void SwitchPanel(PanelName panelName)
    {
        EventParamete eventParamete = new EventParamete();
        eventParamete.AddParameter<PanelName>(panelName);
        EventManager.TriggerEvent(GenericEventEnumType.Message, PanelSwitch.PanelToState.ToString(), eventParamete);
    }
}

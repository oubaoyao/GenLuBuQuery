using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;

public class UsageTask : BaseTask
{
    public UsageTask(BaseState state) : base(state)
    {
    }

    public override void Enter()
    {
        base.Enter();
        UIManager.CreatePanel<UsagePanel>(WindowTypeEnum.ForegroundScreen);
    }

    public override void Exit()
    {
        base.Exit();
        UIManager.ChangePanelState<UsagePanel>(WindowTypeEnum.ForegroundScreen, UIPanelStateEnum.Hide);
    }
}

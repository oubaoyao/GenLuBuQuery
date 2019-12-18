using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;

public class QueryTask : BaseTask
{
    public QueryTask(BaseState state) : base(state)
    {
    }

    public override void Enter()
    {
        base.Enter();
        UIManager.CreatePanel<QueryPanel>(WindowTypeEnum.ForegroundScreen);
    }

    public override void Exit()
    {
        base.Exit();
        UIManager.ChangePanelState<QueryPanel>(WindowTypeEnum.ForegroundScreen, UIPanelStateEnum.Hide);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;

public class CatalogTask : BaseTask
{
    public CatalogTask(BaseState state) : base(state)
    {
    }

    public override void Enter()
    {
        base.Enter();
        UIManager.CreatePanel<CatalogPanel>(WindowTypeEnum.ForegroundScreen);
    }

    public override void Exit()
    {
        base.Exit();
        UIManager.ChangePanelState<CatalogPanel>(WindowTypeEnum.ForegroundScreen, UIPanelStateEnum.Hide);
    }
}

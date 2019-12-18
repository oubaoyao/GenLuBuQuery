using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using MTFrame.MTEvent;

public class BGPanel : BasePanel
{
    public static BGPanel Instance;

    public CanvasGroup Ship;

    public Transform transform1, transform2;

    private float RotateSpeed = 2.0f;

    protected override void Awake()
    {
        Instance = this;
        base.Awake();
    }

    public override void InitFind()
    {
        base.InitFind();
        Ship = FindTool.FindChildComponent<CanvasGroup>(transform, "ShipImage");
        transform1 = FindTool.FindChildNode(transform, "Image");
        transform2 = FindTool.FindChildNode(transform, "Image (1)");
    }

    public override void InitEvent()
    {
        base.InitEvent();
    }

    public void ShipOpen()
    {
        Ship.alpha = 1;
    }

    public void ShipHide()
    {
        Ship.alpha = 0;
    }

    private void Update()
    {
        transform1.Rotate(Vector3.forward * RotateSpeed);
        transform2.Rotate(Vector3.forward * RotateSpeed);
    }
}

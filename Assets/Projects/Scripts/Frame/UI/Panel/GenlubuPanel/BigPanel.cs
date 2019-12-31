using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using UnityEngine.UI;

public class BigPanel : BasePanel
{
    public RawImage BookImage;

    public Button[] PageButtons;

    public QueryPanel queryPanel;

    public override void InitFind()
    {
        base.InitFind();
        PageButtons = FindTool.FindChildNode(transform, "PageButtons").GetComponentsInChildren<Button>();
        BookImage = FindTool.FindChildComponent<RawImage>(transform, "BookImage");

        queryPanel = FindTool.FindParentComponent<QueryPanel>(transform, "QueryPanel");
    }

    public override void InitEvent()
    {
        base.InitEvent();
        //PageButtons[0].onClick.AddListener(() => {
        //    queryPanel.Page_Privious();
        //    SetBookTexture();
        //});

        //PageButtons[1].onClick.AddListener(() => {
        //    queryPanel.Page_Next();
        //    SetBookTexture();
        //});

        BookImage.transform.GetComponent<Button>().onClick.AddListener(() => {
            Hide();
        });
    }

    public override void Open()
    {
        base.Open();
        SetBookTexture();
    }

    private void SetBookTexture()
    {
        BookImage.texture = queryPanel.BookImage.texture;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MTFrame;
using MTFrame.MTEvent;
using UnityEngine.UI;

public class QueryPanel : BasePanel
{
    public Button BackButton;

    public Button[] PageButtons;

    public RawImage BookImage;

    //public Texture[] BookTexture;

    //private int Current_Page = 0;

    public BigPanel bigPanel;

    public BookPro bookPro;

    public override void InitFind()
    {
        base.InitFind();
        BackButton = FindTool.FindChildComponent<Button>(transform, "backButton");
        PageButtons = FindTool.FindChildNode(transform, "PageButtons").GetComponentsInChildren<Button>();
        BookImage = FindTool.FindChildComponent<RawImage>(transform, "BookImage");

        bigPanel = FindTool.FindChildComponent<BigPanel>(transform, "BigPanel");

        bookPro = FindTool.FindChildComponent<BookPro>(transform, "book/BookPro");

        //BookTexture = Resources.LoadAll<Texture>("书");
    }

    public override void InitEvent()
    {
        base.InitEvent();
        BackButton.onClick.AddListener(() => {
            GenLuBuState.SwitchPanel(PanelName.CatalogPanel);
        });

        //PageButtons[0].onClick.AddListener(() => {
        //    Page_Privious();
        //});

        //PageButtons[1].onClick.AddListener(() => {
        //    Page_Next();
        //});

        BookImage.transform.GetComponent<Button>().onClick.AddListener(() => {
            bigPanel.Open();
        });
    }

    public override void Open()
    {
        base.Open();
        bookPro.CurrentPaper = 1;
        //Current_Page = 0;
        //if (BookTexture != null && BookTexture.Length > 0)
        //{
        //    BookImage.texture = BookTexture[Current_Page];
        //}

    }

    public override void Hide()
    {
        base.Hide();
        bigPanel.Hide();
    }

    //public void Page_Privious()
    //{
    //    if(BookTexture!=null&& BookTexture.Length>0)
    //    {
    //        Current_Page--;
    //        if(Current_Page <= 0)
    //        {
    //            Current_Page = 0;
    //        }
    //        BookImage.texture = BookTexture[Current_Page];
    //    }
    //}

    //public void Page_Next()
    //{
    //    if (BookTexture != null && BookTexture.Length > 0)
    //    {
    //        Current_Page++;
    //        if (Current_Page >= BookTexture.Length-1)
    //        {
    //            Current_Page = BookTexture.Length-1;
    //        }
    //        BookImage.texture = BookTexture[Current_Page];
    //    }
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MessageApp : AppObject
{
    public GameObject messageAppContent;


    public override void CloseApp()
    {
        messageAppContent.transform.DOScale(0, 0.5f).OnComplete(() => { messageAppContent.SetActive(false);});
        base.CloseApp();
    }

    public override void OpenApp()
    {
        messageAppContent.SetActive(true);

        messageAppContent.transform.DOScale(1, 0.5f);
        base.OpenApp();
    }
}

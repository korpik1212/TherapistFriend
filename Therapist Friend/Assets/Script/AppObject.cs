using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;
public class AppObject : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{












    public virtual void OpenApp()
    {

    }

    public virtual void CloseApp()
    {

    }


    public void OnPointerClick(PointerEventData eventData)
    {
        OpenApp();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(1.2f, 0.2f);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(1f, 0.2f);

    }
}

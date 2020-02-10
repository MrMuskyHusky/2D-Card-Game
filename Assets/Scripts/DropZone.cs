using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour,IPointerEnterHandler, IPointerExitHandler 
{
    public static bool playable;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnPointerEnter");
        playable = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnPointerExit");
        playable = false;
    }
}


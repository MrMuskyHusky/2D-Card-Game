using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardHilight : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    public bool freezeMovement;

    public Vector3 startPos;
    public bool mouseOver = false;
    public bool isDragging = false;

    public GameObject highlightedObject;
    public Transform dropZone;


    private Renderer rend;
    // On Mouse Over - Highlight or Glow
    // On Mouse Down - Move/Selected
    // On Mouse Up - Place in world space


    public bool hover = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startPos = this.transform.position;
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
        this.transform.localScale = new Vector3(0.75f, 0.75f, 0.7f);
        hover = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
        this.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        hover = false;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        SelectedCard.selectedObject = this.gameObject;
        SelectedCard.selectedObject.GetComponent<CardDisplay>().baseUI.raycastTarget = false;
        isDragging = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (DropZone.playable)
        {
            Instantiate(SelectedCard.selectedObject.GetComponent<CardDisplay>().prefab, dropZone);
            SelectedCard.selectedObject.GetComponent<CardDisplay>().baseUI.raycastTarget = true;

            Destroy(SelectedCard.selectedObject);
            freezeMovement = true;
        }
        else
        {
            SelectedCard.selectedObject.GetComponent<CardDisplay>().baseUI.raycastTarget = true;

            this.transform.position = startPos;
            freezeMovement = false;
        }
        SelectedCard.selectedObject = null;
    }
}
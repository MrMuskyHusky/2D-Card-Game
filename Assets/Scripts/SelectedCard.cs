using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCard : MonoBehaviour
{
    public static GameObject selectedObject;
    // && selectedObject.GetComponent<CardHilight>().freezeMovement == false
    void Update()
    {
        if (selectedObject != null)
        {
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            selectedObject.transform.position = pos;
        }
    }
}

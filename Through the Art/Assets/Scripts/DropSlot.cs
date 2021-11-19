using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    //string con tag esperando y en el hijo se le pone el tag, para que haga una comparacion después del parent

    void Start()
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragHandler.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        if(item!=null && item.transform.parent != transform)
        {
            item = null;
        }
    }
}

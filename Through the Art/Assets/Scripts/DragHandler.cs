using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    // se implementan las interfaces de los Idraghandler, Ienddraghandler y Ibegindraghandler, para que se puedan 
    // esto porque arriba pusimos interfaces, son funciones vacías
    public static GameObject itemDragging;

    Vector3 startPosition; //almacena posición inicial del item
    Transform startParent; //posición del start parent
    Transform dragParent;

    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //esta funcion se llama una vez cuando se agarra el objeto la primera vez
        //Debug.Log("OnBeginDrag");
        itemDragging = gameObject;

        //guardamos las variables
        startPosition = transform.position;
        startParent = transform.parent;
        //se le asigna un nuevo parent
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        //esta funcion se llama cada que el objeto está en uso, osea cada que el mouse esté draggeando el objeto
        
        //Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
        //hace que se pueda mover el objeto dependiendo la posición del mouse
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //esta función se llama cuando se suelta el objeto
        //Debug.Log("OnEndDrag")
        itemDragging = null;

        if (transform.parent == dragParent)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
    }
    void Update()
    {

    }
}

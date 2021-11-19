using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonCodeController : MonoBehaviour
{
    public GameObject recolectablePuzzle4;
    //Rasycast basado en la clase donde Judith nos lo enseñó

    CodeLock codeLock; //Crea una variable que trae al script CodeLock
    int raycastRange = 10000; //Rango de alcance del raycast

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            VeriHit();
        }
    }

    void VeriHit()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, raycastRange))
        {
            //Debug.Log(hit.transform.name);
            codeLock = hit.transform.gameObject.GetComponentInParent<CodeLock>();

            

            if (codeLock != null)
            {
                string value = hit.transform.name;
                codeLock.SetValue(value);
            }

            if (hit.transform.gameObject.tag == "ObjetoRecolectable")
            {
                Debug.Log("Recolectado");
                //recolectablePuzzle4.SetActive(true);
                hit.transform.gameObject.SetActive(false);
                GameManager.recolectadoPuzzle4 = 1;
                
                /*Destroy(gameObject);
                objetosDesordenados.SetActive(false);
                //tablaMadera.SetActive(false);
                GameManager.tablaMadera = 1;
                GameManager.objetosRecolectaodos = GameManager.objetosRecolectaodos + 1;*/
            }
        }
    }
}

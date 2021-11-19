using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject objetosDesordenados;

    public GameObject recolectablePuzzle1;

    public Camera fpsCam;
    public float range = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Shoot();
            SelectionRay();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }

    void SelectionRay()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Creando el raycast

        if (Physics.Raycast(ray, out hit)) //Pregunto si hubo hit
        {
            if (hit.transform.gameObject.tag == "Linoleo")
            {
                Debug.Log(hit.transform.name);
                recolectablePuzzle1.SetActive(true);
                //GameManager.recolectadoPuzzle1 = 1;
                /*Destroy(gameObject);
                objetosDesordenados.SetActive(false);
                //tablaMadera.SetActive(false);
                GameManager.tablaMadera = 1;
                GameManager.objetosRecolectaodos = GameManager.objetosRecolectaodos + 1;*/
            }

            if (hit.transform.gameObject.tag == "ObjetoRecolectable")
            {
                Debug.Log("Recolectado");
                //recolectablePuzzle1.SetActive(true);
                hit.transform.gameObject.SetActive(false);
                GameManager.recolectadoPuzzle1 = 1;
                /*Destroy(gameObject);
                objetosDesordenados.SetActive(false);
                //tablaMadera.SetActive(false);
                GameManager.tablaMadera = 1;
                GameManager.objetosRecolectaodos = GameManager.objetosRecolectaodos + 1;*/
            }
        }
    }
}

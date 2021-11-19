using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle1E : MonoBehaviour
{
    public GameObject objetosDesordenados;
    public GameObject tablaMadera;

    

    // Start is called before the first frame update
    void Start()
    {
        objetosDesordenados.SetActive(false);
        tablaMadera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameManager.primeraVez == 1)
        {
            Debug.Log("Encendido");
            objetosDesordenados.SetActive(true);
            tablaMadera.SetActive(true);
            GameManager.primeraVez = 0;
            this.gameObject.SetActive(false);
        }
        
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int hongos, lives, pocion;

    public static int tablaMadera, objetosRecolectaodos, recolectadoPuzzle1, recolectadoPuzzle4;

    public static int primeraVez;

    //public Image[] assetPlayerLives;
    public static int livesLimit;

    public static int ingredientes;

    // Start is called before the first frame update
    void Start()
    {
        primeraVez = 1;
        //hongos = PlayerPrefs.GetInt("totalHongos");
        tablaMadera = 0;
        //lives = PlayerPrefs.GetInt("totalLives");
        lives = 3;
        objetosRecolectaodos = 0;
        recolectadoPuzzle1 = 0;
        recolectadoPuzzle4 = 0;
        livesLimit = 6;
        //assetPlayerLives[0].gameObject.SetActive(true);
    }

    /*void SetLivesUI()
    {
        for (int i = 0; i < lives; i++)
        {
            assetPlayerLives[i].gameObject.SetActive(true);
        }

        for (int i = lives; i < assetPlayerLives.Length; i++)
        {
            assetPlayerLives[i].gameObject.SetActive(false);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Debug.Log("r");

            /*if (PlayerWolf.tienePocion)
            {
                StartCoroutine(LaunchVictory());
            }*/

        }
    }

    IEnumerator LaunchVictory()
    {
        //PersistantData.totalHongos = 0;
        tablaMadera = 0;
        //PersistantData.totalLives = 3;
        lives = 3;
        objetosRecolectaodos = 0;
        primeraVez = 1;
        /*uIText.gameObject.GetComponent<Text>().text = message;
        uITextShadow.gameObject.GetComponent<Text>().text = message;

        uIText.gameObject.SetActive(true);
        uITextShadow.gameObject.SetActive(true);*/
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(3);
    }
}

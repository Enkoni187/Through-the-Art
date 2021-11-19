using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    public GameObject uIText, uITextShadow;

    public bool invincible;

    public static bool tienePocion = false;

    public static int ayudaHongos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (ayudaHongos == 5)
        {

            StartCoroutine(showMessage("Congratulations! Now you can make the potion. Go to the cauldron to make it"));
            //pocion.gameObject.SetActive(true);
            //GameManager.hongos = 0;
            ayudaHongos = 0;
            //GameManager.ingredientes = 1;

        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            /*Debug.Log("ChocoEnemigo");
            if (GameManager.lives <= 1)
            {
                StartCoroutine(LaunchGameOver());
            }
            else
            {
                GameManager.lives--;
                StartCoroutine(SetInvincible());
            }*/
        }
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Dulce")
        {
            /*Debug.Log("TomoDulce");
            if (GameManager.livesLimit > GameManager.lives)
            {
                GameManager.lives++;
                Destroy(col.gameObject);
            }*/
        }

        else if (col.gameObject.tag == "Hongo")
        {
            /*Debug.Log("Encontrohongo");
            GameManager.hongos++;
            ayudaHongos++;
            //PersistantData.totalHongos++;
            Destroy(col.gameObject);*/
        }

        else if (col.gameObject.tag == "Potion")
        {
            /*Debug.Log("Tiene poción");
            NPC.dialogCase = 1;
            Destroy(col.gameObject);
            tienePocion = true;*/
        }

        else if (col.gameObject.tag == "Enemy")
        {
            /*Debug.Log("ChocoEnemigo");
            if (GameManager.lives <= 1)
            {
                StartCoroutine(LaunchGameOver());
            }
            else
            {
                GameManager.lives--;
                StartCoroutine(SetInvincible());
            }*/
        }

    }

    IEnumerator SetInvincible()
    {
        invincible = true;
        yield return new WaitForSeconds(2);
        invincible = false;
    }

    IEnumerator LaunchGameOver()
    {
        //PersistantData.totalHongos = 0;
        //GameManager.hongos = 0;
        //PersistantData.totalLives = 3;
        //GameManager.lives = 3;
        //GameManager.pocion = 0;
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(4);
    }

    IEnumerator showMessage(string message)
    {
        uIText.gameObject.GetComponent<Text>().text = message;
        uITextShadow.gameObject.GetComponent<Text>().text = message;

        uIText.gameObject.SetActive(true);
        uITextShadow.gameObject.SetActive(true);

        yield return new WaitForSeconds(5);
        uIText.gameObject.SetActive(false);
        uITextShadow.gameObject.SetActive(false);


    }
}

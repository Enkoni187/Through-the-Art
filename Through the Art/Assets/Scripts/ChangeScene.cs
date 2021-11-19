using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int sceneIndex;
    

    private void OnTriggerEnter(Collider other)
    {
        
        GameManager.tablaMadera = 0;
        //lives = PlayerPrefs.GetInt("totalLives");
        GameManager.lives = 3;
        GameManager.objetosRecolectaodos = 0;
        GameManager.recolectadoPuzzle1 = 0;
        GameManager.recolectadoPuzzle4 = 0;
        GameManager.livesLimit = 6;
        SceneManager.LoadScene(sceneIndex);
    }
}

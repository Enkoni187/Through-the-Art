using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject pausePanel, unpausePanel;
    public GameObject objetosDesordenados;
    public GameObject tablaMadera;
    public void GoToScene(int sceneIndex)
    {

        SceneManager.LoadScene(sceneIndex);
        GameManager.tablaMadera = 0;
        //lives = PlayerPrefs.GetInt("totalLives");
        GameManager.lives = 3;
        GameManager.objetosRecolectaodos = 0;
        GameManager.recolectadoPuzzle1 = 0;
        GameManager.recolectadoPuzzle4 = 0;
        GameManager.livesLimit = 6;
        SceneManager.LoadScene(sceneIndex);

    }

    public void Pause()
    {
        pausePanel.SetActive(false); // con esto va a desaparacer el boton de pausa y dejar a la vista el de play
        unpausePanel.SetActive(true);
        Time.timeScale = 0; // si aqui dice cero se congela todo 
    }
    public void UnPause()
    {
        pausePanel.SetActive(true);
        unpausePanel.SetActive(false);
        Time.timeScale = 1; // aqui vuelve el tiempo a la normalidad
    }

    public void TerminarPuzzle1()
    {
        objetosDesordenados.SetActive(false);
        tablaMadera.SetActive(false);
        GameManager.tablaMadera = 1;
        GameManager.objetosRecolectaodos = GameManager.objetosRecolectaodos + 1;
    }
}

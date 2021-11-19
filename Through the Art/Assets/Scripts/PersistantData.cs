using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantData : MonoBehaviour
{
    public static int totalHongos, totalLives;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("totalHongos"))
        {
            totalHongos = PlayerPrefs.GetInt("totalHongos");
        }
        else
        {
            totalHongos = 0;
            PlayerPrefs.SetInt("totalHongos", totalHongos);
        }

        if (PlayerPrefs.HasKey("totalLives"))
        {
            totalLives = PlayerPrefs.GetInt("totalLives");
        }
        else
        {
            totalLives = 3;
            PlayerPrefs.SetInt("totalLives", totalLives);
        }


    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("totalHongos", totalHongos);
        PlayerPrefs.SetInt("totalLives", totalLives);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    public Text[] uITexts;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (uITexts[0] != null)
        {
            uITexts[0].text = "x " + GameManager.lives.ToString();
        }*/
        if (uITexts[1] != null)
        {
            uITexts[1].text = "x " + GameManager.lives.ToString();
        }
        //texto hongos
        if (uITexts[2] != null)
        {
            uITexts[2].text = "x " + GameManager.hongos.ToString();
        }
        //sombra texto hongos
        if (uITexts[3] != null)
        {
            uITexts[3].text = "x " + GameManager.hongos.ToString();
        }
        /*if (uITexts[4] != null)
        {
            uITexts[4].text = "x " + PersistantData.totalMultiplier.ToString();
        }
        if (uITexts[5] != null)
        {
            uITexts[5].text = "x " + PersistantData.totalMultiplier.ToString();
        }*/

        if (GameManager.ingredientes == 1)
        {
            uITexts[5].text = "x 5 ";
            //uITexts[2].gameObject.GetComponent<Text>().text;
            //uITexts[2].text
        }

    }
}

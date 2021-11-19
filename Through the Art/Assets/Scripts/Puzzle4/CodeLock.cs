using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeLock : MonoBehaviour
{
    //Código guía: How To: Codelock - Unity Tutorial Url: https://www.youtube.com/watch?v=YAAG-JczuGY

    int longCode; //Longitud de la claver (4)
    int posNumCode; //Posicion de la clave en la pantalla

    public string code = ""; //El código correcto
    public string inputCode;//Código que el usuario estará metiendo

    public GameObject recolectablePuzzle4;

    public GameObject textFelicidades;
    public GameObject textCodigoInc;


    public Text uIText;
    private void Start()
    {
        longCode = code.Length; //La longitud del código sea igual a la longitud de la variable code
    }

    public void SetValue(string value)
    {
        posNumCode++; //Cada vez que se escriba un valor se aumentará la posición para que el siguiente valor se escriba en la siguiente posición

        if (posNumCode <= longCode)
        {
            inputCode += value; //
            
                if (uIText != null)
                {
                    uIText.text = inputCode.ToString();
                }
            
        }

        if (posNumCode == longCode)
        {
            VeriCodigo(); //Manda a llamar la función para verificar si el cóigo escrito es correcto
            inputCode = ""; //Después de verificar el código que el usuario escribió la va a borrar
            posNumCode = 0; //Restaurar la posición en la pantalla a 0
        }

    }

    void VeriCodigo()
    {
        if (inputCode == code)
        {
            //Debug.Log("¡Felicidades! Has logrado completar el último puzzle");
            recolectablePuzzle4.SetActive(true);
            textFelicidades.SetActive(true);
            //StartCoroutine(YouWin)
        }
        else
        {
            //Debug.Log("Código incorrecto");
            //textCodigoInc.SetActive(true);
            StartCoroutine(CodigoIncorrecto());
        }
    }

    IEnumerator CodigoIncorrecto()
    {
        //Debug.Log("Código incorrecto");
        textCodigoInc.SetActive(true);
        yield return new WaitForSeconds(1f);
        textCodigoInc.SetActive(false);
    }
}

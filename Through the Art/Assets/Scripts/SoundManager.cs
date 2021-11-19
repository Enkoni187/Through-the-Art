using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource source;
    public AudioClip[] clips;
    int currentScene;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(this.gameObject);
        }
        //source = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != currentScene)
        {
            currentScene = SceneManager.GetActiveScene().buildIndex;
            ChangeMusic();
        }
    }

    void ChangeMusic()
    {
        /*source.Stop();
        source.clip = clips[SceneManager.GetActiveScene().buildIndex];
        source.Play();*/

        /*if (currentScene == 0 || currentScene == 2)
        {
            source.Stop();
            source.clip = clips[0];
            source.Play();
        }
        else
        {*/
        source.Stop();
        source.clip = clips[SceneManager.GetActiveScene().buildIndex];
        source.Play();
        //}
    }
}

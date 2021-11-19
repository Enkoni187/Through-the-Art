using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider = GetComponent<Slider>();
        volumeSlider.value = SoundManager.instance.source.volume;
    }



    public void SetVolume()
    {
        SoundManager.instance.source.volume = volumeSlider.value;
    }
}

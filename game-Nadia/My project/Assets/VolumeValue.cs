using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private AudioSource audioSrc;

    private float musicVolume = 1f; //Громкость


    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void ChangeVolume(float vol) //Изменение звука
    {
        musicVolume  = vol;
    }
}

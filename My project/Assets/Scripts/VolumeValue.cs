using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private static List<AudioSource> audioSources = new List<AudioSource>();
    private float musicVolume = 1f; // Громкость 

    // Start is called before the first frame update 
    void Start()
    {
        FindAllAudioSources(); // Находим все AudioSource в проекте
    }

    // Update is called once per frame 
    void Update()
    {
        foreach (AudioSource audioSrc in audioSources)
        {
            audioSrc.volume = musicVolume; // Устанавливаем громкость для всех AudioSource 
        }
    }

    public void ChangeVolume(float vol) // Изменение звука 
    {
        musicVolume = vol;
    }

    private void FindAllAudioSources()
    {
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>(); // Находим все AudioSource в проекте

        foreach (AudioSource audioSrc in allAudioSources)
        {
            audioSources.Add(audioSrc); // Добавляем каждый AudioSource в список
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour

{
    public Slider volumeSlider;
    public AudioSource backgroundMusic;

    private void Start()
    {
        if (backgroundMusic == null)
        {
            Debug.LogError("AudioSource is not assigned in the inspector!");
        }
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        backgroundMusic.volume = volume;
    }
}

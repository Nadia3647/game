using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private static List<AudioSource> audioSources = new List<AudioSource>();
    private float musicVolume = 1f; // ��������� 

    // Start is called before the first frame update 
    void Start()
    {
        FindAllAudioSources(); // ������� ��� AudioSource � �������
    }

    // Update is called once per frame 
    void Update()
    {
        foreach (AudioSource audioSrc in audioSources)
        {
            audioSrc.volume = musicVolume; // ������������� ��������� ��� ���� AudioSource 
        }
    }

    public void ChangeVolume(float vol) // ��������� ����� 
    {
        musicVolume = vol;
    }

    private void FindAllAudioSources()
    {
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>(); // ������� ��� AudioSource � �������

        foreach (AudioSource audioSrc in allAudioSources)
        {
            audioSources.Add(audioSrc); // ��������� ������ AudioSource � ������
        }
    }
}

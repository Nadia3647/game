using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Random = UnityEngine.Random;

public class VideoController : MonoBehaviour
{

    public VideoClip[] videoClips;   // массив видеоклипов
    public VideoPlayer currentPlayer;
    public VideoPlayer nextPlayer;
    private int currentClipIndex = 0;

    void Start()
    {
        currentPlayer.loopPointReached += OnVideoEnd;
        nextPlayer.prepareCompleted += OnNextVideoPrepared;
        PlayVideo(currentClipIndex);
    }

    void PlayVideo(int clipIndex)
    {
        currentPlayer.clip = videoClips[clipIndex];
        currentPlayer.Play();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        currentClipIndex++;
        if (currentClipIndex < videoClips.Length)
        {
            nextPlayer.clip = videoClips[currentClipIndex];
            nextPlayer.Prepare();
        }
        else
        {
            currentClipIndex = 0;  // Опционально: начать с первого видео после завершения всех
            nextPlayer.clip = videoClips[currentClipIndex];
            nextPlayer.Prepare();
        }
    }

    void OnNextVideoPrepared(VideoPlayer vp)
    {
        currentPlayer.Stop();
        SwapPlayers();
    }

    void SwapPlayers()
    {
        VideoPlayer temp = currentPlayer;
        currentPlayer = nextPlayer;
        nextPlayer = temp;
        currentPlayer.Play();
    }
}
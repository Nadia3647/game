using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer1;
    public VideoPlayer videoPlayer2;
    public VideoPlayer videoPlayer3;
    public VideoClip video1Clip;
    public VideoClip video2Clip;
    public VideoClip video3Clip;
    private bool isPlayingVideo2 = false;
    private bool isPlayingVideo3 = false;
    private VideoPlayer currentVideoPlayer;
    private VideoPlayer nextVideoPlayer;

    void Start()
    {
        videoPlayer1 = gameObject.AddComponent<VideoPlayer>();
        videoPlayer2 = gameObject.AddComponent<VideoPlayer>();
        videoPlayer3 = gameObject.AddComponent<VideoPlayer>();
        currentVideoPlayer = videoPlayer1;
        nextVideoPlayer = videoPlayer2;

        PrepareAndPlay(currentVideoPlayer, video1Clip, false, PlayVideo2Loop);
    }

    void Update()
    {
        if (Sleep.sleep == 1 && !isPlayingVideo3)
        {
            isPlayingVideo3 = true;
            currentVideoPlayer.loopPointReached -= PlayVideo2Loop;
            PrepareAndPlay(videoPlayer3, video3Clip, false, OnVideo3End);
            currentVideoPlayer.Stop(); // Останавливаем проигрывание текущего видео перед переключением на другой
            currentVideoPlayer = videoPlayer3;
        }
    }

    void PlayVideo2Loop(VideoPlayer vp)
    {
        if (!isPlayingVideo2)
        {
            isPlayingVideo2 = true;
            currentVideoPlayer.loopPointReached -= PlayVideo2Loop;
            PrepareAndPlay(videoPlayer2, video2Clip, true, null);
            currentVideoPlayer.Stop();
            currentVideoPlayer = videoPlayer2;
        }
    }

    void OnVideo3End(VideoPlayer vp)
    {
        SceneManager.LoadScene(5);
    }

    void PrepareAndPlay(VideoPlayer player, VideoClip clip, bool loop, VideoPlayer.EventHandler loopPointReachedHandler)
    {
        player.clip = clip;
        player.isLooping = loop;
        if (loopPointReachedHandler != null)
        {
            player.loopPointReached += loopPointReachedHandler;
        }
        player.prepareCompleted += (VideoPlayer vp) => { player.Play(); };
        player.Prepare();
    }
}
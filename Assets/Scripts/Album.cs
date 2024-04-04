using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Album : MonoBehaviour
{
    [SerializeField] List<AudioClip> audioSources;
    int currentSongIndex = 0;
    public AudioSource audioSource;
    
    AudioClip currentSong;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentSong = audioSources[0];
        audioSource.clip = currentSong;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayPause()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        } else {
            audioSource.Play();
        }
    }

    public void NextSong()
    {
        if(currentSongIndex < audioSources.Count - 1)
        {
            currentSongIndex++;
        }
        else
        {
            currentSongIndex = 0;
        }

        audioSource.clip = audioSources[currentSongIndex]; ;
        audioSource.Play();
    }

    public void PreviousSong()
    {
        if (currentSongIndex > 0)
        {
            currentSongIndex--;
        }
        else
        {
            currentSongIndex = audioSources.Count;
        }

        audioSource.clip = audioSources[currentSongIndex];
        audioSource.Play();
    }

    public void Stop()
    {
        audioSource.Stop();
    }
}

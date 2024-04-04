using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Album : MonoBehaviour
{
    [SerializeField] List<AudioClip> audioSources;
    int currentSongIndex;
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
        currentSong = audioSources[currentSongIndex];
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
        if(currentSongIndex < audioSources.Count)
        {
            currentSongIndex++;
        }
        else
        {
            currentSongIndex = 0;
        }

        audioSource.clip = currentSong;
        audioSource.Play();
    }

    public void PreviousSong()
    {
        if (currentSongIndex != 0)
        {
            currentSongIndex--;
        }
        else
        {
            currentSongIndex = audioSources.Count;
        }

        audioSource.clip = currentSong;
        audioSource.Play();
    }
}

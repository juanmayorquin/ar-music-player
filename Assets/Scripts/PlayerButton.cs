using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerButton : MonoBehaviour
{
    [SerializeField] Sprite playSprite, pauseSprite;
    [SerializeField] Album album;
    bool isPlayButton;
    Sprite actualSprite;

    private void Start()
    {
        album = GetComponentInParent<Album>();
    }

    private void Update()
    {
        
    }

    public void PlayPause()
    {
        //if (album.audioSource.isPlaying)
        //{
        //    actualSprite = pauseSprite;
        //    GetComponent<Image>().sprite = actualSprite;
        //}
        //else
        //{
        //    actualSprite = playSprite;
        //    GetComponent<Image>().sprite = actualSprite;
        //}

        album.PlayPause();
    }

    public void NextSong()
    {
        album.NextSong();
    }

    public void PreviousSong()
    {
        album.PreviousSong();
    }
}

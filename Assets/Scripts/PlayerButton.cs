using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerButton : MonoBehaviour
{
    [SerializeField] Sprite playSprite, pauseSprite;
    [SerializeField] Album album;
    Sprite actualSprite;

    private void Start()
    {
        album = GetComponentInParent<Album>();
    }

    private void Update()
    {
        if (album.audioSource.isPlaying)
        {
            actualSprite = pauseSprite;
            GetComponent<Image>().sprite = actualSprite;
        }
        else
        {
            actualSprite = playSprite;
            GetComponent<Image>().sprite = actualSprite;
        }
    }

    public void PlayPause()
    {
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

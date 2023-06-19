using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrack : MonoBehaviour
{
    private AudioSource soundTrack;

    private void Awake()
    {
        this.soundTrack = this.GetComponent<AudioSource>();
    }

    public void  StopSound()
    {
        this.soundTrack.Stop();
    }

    public void PlaySound()
    {
        this.soundTrack.Play();
    }
}

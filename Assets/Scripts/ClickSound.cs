using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioSource aud;
    public AudioClip click;

    public void ClickSnd()
    {
        aud.PlayOneShot(click);
    }
}

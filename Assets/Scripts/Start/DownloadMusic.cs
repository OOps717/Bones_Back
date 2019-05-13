using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DownloadMusic : MonoBehaviour
{

    public AudioMixer AllMusic;
    // Start is called before the first frame update
    void Start()
    {
        AllMusic.SetFloat("Music", PlayerPrefs.GetFloat("Music", 0f));
        AllMusic.SetFloat("Sounds", PlayerPrefs.GetFloat("Sounds", 0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

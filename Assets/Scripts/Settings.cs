using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer AllMusic;
    Resolution[] resolutions;
    public Dropdown resDropDown;
    int currentResolutionIndex;
    public Slider music;
    public Slider sounds;

    private void Start()
    {

        music.value = PlayerPrefs.GetFloat("Music", 0f);
        sounds.value = PlayerPrefs.GetFloat("Sounds", 0f);

        resolutions = Screen.resolutions;//this line to change for certain resolutions
        resDropDown.ClearOptions();
        currentResolutionIndex = 0;
        List<string> options = new List<string>();
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resDropDown.AddOptions(options);
        resDropDown.value = currentResolutionIndex;
        resDropDown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume(float vol)
    {
        AllMusic.SetFloat("Music", vol);
        PlayerPrefs.SetFloat("Music", vol);
        PlayerPrefs.Save();
    }

    public void SetSoundsVolume(float vol)
    {
        AllMusic.SetFloat("Sounds", vol);
        PlayerPrefs.SetFloat("Sounds", vol);
        PlayerPrefs.Save();
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen (bool Full)
    {
        Screen.fullScreen = Full;
    }


}

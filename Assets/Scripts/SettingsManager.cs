using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider singSlider;

    public GameObject settingsPanel;

    void Start()
    {
        settingsPanel.SetActive(false);
    }
    void Update()
    {
        
    }
    public void OnSettingsClicked()
    {
        settingsPanel.SetActive(true);
    }
    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }
    public void SetMusicVolume()
    {
        float volumeBGM = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volumeBGM)*20);
    }
    public void SetSingerVolume()
    {
        float singVolume = singSlider.value;
        myMixer.SetFloat("singer", Mathf.Log(singVolume)*20);
    }
}

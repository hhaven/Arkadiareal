using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public AudioSource musicSource;
    public AudioSource effectSource;

    //public AudioClip SoundMenu;
    //public AudioClip effectMenu;

    public Slider sliderMusic;  
    public Slider sliderSFX;

    public static AudioManager instance;

    void Awake()
    {
        instance = this;
        InitVolume();
    }

    private void InitVolume()
    {
        musicSource.volume = PlayerPrefs.GetFloat("musicVolumen", 1.0f);
        effectSource.volume = PlayerPrefs.GetFloat("sfxVolumen", 1.0f);

        sliderMusic.value = musicSource.volume;
        sliderSFX.value = effectSource.volume;
    }

    public void PlayAudio(AudioClip audioClip)
    {
            musicSource.clip = audioClip;
            musicSource.Play();
    }

    public void PlayEffect(AudioClip audioClip)
    {
        effectSource.clip = audioClip;
        effectSource.Play();
    }


    public void MusicVolumeUpdate()
    {
        musicSource.volume = sliderMusic.value;
        PlayerPrefs.SetFloat("musicVolumen", musicSource.volume);
        PlayerPrefs.Save();
    }

    public void SFXVolumeUpdate()
    {
        effectSource.volume = sliderSFX.value;
        PlayerPrefs.SetFloat("sfxVolumen", effectSource.volume);
        PlayerPrefs.Save();
    }

    



}

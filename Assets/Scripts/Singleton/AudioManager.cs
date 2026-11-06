using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    //AK BOILERPLATE CODE 

    public void PlaySound(AudioSource clip)
    {
       
        clip.Play();
    }

    public void PlayMusic(AudioSource clipM)
    {
        clipM.Play();
        DontDestroyOnLoad(clipM);
    }





}

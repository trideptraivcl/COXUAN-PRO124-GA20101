using UnityEngine;

public class AudioManager : MonoBehaviour
{   //tao bien luu tru
    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    //tao luu tru audio clip
    public AudioClip musicClip;
    public AudioClip coinClip;
    public AudioClip winClip;
    public AudioClip buiClip;
    void Start()
    {
        musicAudioSource.clip = musicClip;
        musicAudioSource.Play();
    }

    public void PlaySFX(AudioClip sfxClip)
    {
        vfxAudioSource.clip = sfxClip;
        musicAudioSource.PlayOneShot(sfxClip);
    }

}
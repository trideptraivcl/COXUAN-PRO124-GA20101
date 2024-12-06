using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Tạo biến lưu trữ
    public AudioSource musicAudioSource;
    public AudioSource vfxAudioSource;

    // Tạo lưu trữ audio clip
    public AudioClip musicClip;
    public AudioClip coinClip;
    public AudioClip winClip;
    public AudioClip buiClip;

    void Start()
    {
        // Gán clip và bật loop cho nhạc nền
        musicAudioSource.clip = musicClip;
        musicAudioSource.loop = true; // Cho phép nhạc nền phát lặp
        musicAudioSource.Play();
    }

    public void PlaySFX(AudioClip sfxClip, bool loop = false)
    {
        // Nếu loop = true, bật chế độ lặp, ngược lại phát một lần
        if (loop)
        {
            vfxAudioSource.clip = sfxClip;
            vfxAudioSource.loop = true;
            vfxAudioSource.Play();
        }
        else
        {
            vfxAudioSource.loop = false;
            vfxAudioSource.PlayOneShot(sfxClip);
        }
    }

    public void StopSFX()
    {
        // Dừng phát hiệu ứng âm thanh
        vfxAudioSource.Stop();
        vfxAudioSource.loop = false;
    }
}

using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shoting")]
    [SerializeField] private AudioClip shootingClip;
    [SerializeField][Range(0f, 1f)] private float shootingVolume = 1f;

    [Header("Damage")]
    [SerializeField] private AudioClip damageClip;
    [SerializeField][Range(0f, 1f)] private float damageVolume = 1f;

    public void PlayShootingClip()
    {
        PlayClip(shootingClip, shootingVolume);
    }

    public void PlaydamageClip()
    {
        PlayClip(damageClip, damageVolume);
    }

    private void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
        }
    }
}
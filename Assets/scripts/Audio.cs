using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip clip;

    public void PlaySFXButton()
    {
        audioSource.clip    = clip;
        audioSource.enabled = false;
        audioSource.enabled = true;
    }
}
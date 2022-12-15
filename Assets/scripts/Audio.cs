using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    public void SonidoBoton()
    {
        audioSource.clip = clip;
        audioSource.enabled = false;
        audioSource.enabled = true;
    }

}
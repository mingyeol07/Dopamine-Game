using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySFX(AudioClip sfx)
    {
        GameObject go = new GameObject(sfx.name);
        AudioSource source = go.AddComponent<AudioSource>();
        source.clip = sfx;
        source.Play();
        Destroy(go, sfx.length);
    }
}

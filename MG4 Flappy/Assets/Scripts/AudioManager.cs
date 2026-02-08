using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [SerializeField] private AudioSource sfxSource;
    [SerializeField] private AudioClip flapClip;
    [SerializeField] private AudioClip scoreClip;
    [SerializeField] private AudioClip hitClip;

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

    }

    // Update is called once per frame
    public void playFlapSound()
    {
       sfxSource.PlayOneShot(flapClip);

    }
    public void PlayScoreSound()
    {
        sfxSource.PlayOneShot(scoreClip);
    }
    public void PlayHitSound()
    {
        sfxSource.PlayOneShot(hitClip);
    }
}

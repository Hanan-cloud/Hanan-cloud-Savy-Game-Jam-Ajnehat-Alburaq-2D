using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect : MonoBehaviour
{

    [SerializeField] private AudioClip WinSound, LoseSound;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {

        audio = GetComponent<AudioSource>();
    }

    public void win()
    {
        audio.PlayOneShot(WinSound);

    }
    public void lose()
    {
        audio.PlayOneShot(LoseSound);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource StartBGM;
    public AudioSource LoopBGM;

    void Start()
    {
        // Play StartBGM once
        StartBGM.Play();
    }

    void Update()
    {
        // Check if StartBGM has finished playing
        if (!StartBGM.isPlaying)
        {
            // If StartBGM has finished, start looping BGM
            if (!LoopBGM.isPlaying)
            {
                LoopBGM.loop = true;
                LoopBGM.Play();
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSourceStart;
    public AudioSource ghostNormal;
    private Boolean startplay = true;
    private Boolean bgmplay = false;
    void Start()
    {
        audioSourceStart = GetComponent<AudioSource>();
        startplay = true;
        bgmplay = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startplay)
        {
            audioSourceStart.Play();
            startplay = false;
        }


    }
}

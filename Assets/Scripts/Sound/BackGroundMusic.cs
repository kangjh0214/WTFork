using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    GameObject Bgm;
    AudioSource backmusic;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    public void ButtonOnOff()
    {
        Bgm = GameObject.Find("Bgm");
        backmusic = Bgm.GetComponent<AudioSource>();
        if (backmusic.isPlaying)
        {
            backmusic.Pause();
            anim.SetTrigger("Off");
        }
        else backmusic.Play();
        anim.SetTrigger("On");
    }
}

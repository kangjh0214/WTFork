using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundOnOff : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void ToggleAudioVolume()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;

        if (AudioListener.volume <= 0)
        {
            anim.SetTrigger("Off");
        }
        else
        {
            anim.SetTrigger("On");
        }
    }


 
}

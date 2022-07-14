using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnOff : MonoBehaviour
{
    [SerializeField] private AudioSource myAudio;
	[SerializeField] private float fadeSpeed;
	private bool fade = false;

	private void Update()
	{
		if (fade) myAudio.volume -= Time.deltaTime * fadeSpeed;
		else myAudio.volume += Time.deltaTime * fadeSpeed;
	}

	public void MuteAudio()
	{
		fade = false;
		myAudio.volume = 0;
	}

	public void UnMuteAudio()
	{
		fade = false;
		myAudio.volume = 1;
	}

	public void AudioFadeOut()
	{
		fade = true;
	}

	public void AudioFadeIn()
	{
		fade = false;
	}
}

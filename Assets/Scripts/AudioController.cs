using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour {

    public Sounds[] sound;

	// Use this for initialization
	void Awake () {

        foreach (Sounds s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
		
	}



    public void Play(string name)
    {
        Sounds s = Array.Find(sound, sounds => sounds.name == name);

        foreach (Sounds x in sound)
        {
            x.source.Stop();
        }

        if (s == null)
        {
            Debug.Log("Can't Find Sound");
            return;
        }
        s.source.Play();
        
    }
}

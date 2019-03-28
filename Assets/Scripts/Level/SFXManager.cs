using UnityEngine;
using System.Collections;

public class SFXManager : MonoBehaviour {

    private AudioSource aSource;

	// Use this for initialization
	void Start () {
        aSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayClip(AudioClip clip)
    {
        aSource.clip = clip;
        aSource.Play();
    }
}

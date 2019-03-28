using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int health;
    public AudioClip shot;

    private LevelManager lvlManager;
    private SFXManager sfxManage;

	// Use this for initialization
	void Start () {
        sfxManage = GetComponent<SFXManager>();
        lvlManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(health <= 0)
        {
            lvlManager.LoadNextScene();
        }
	}

    public void Shot()
    {
        sfxManage.PlayClip(shot);
        health -= 1;
    }
}

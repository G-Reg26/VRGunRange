using UnityEngine;
using System.Collections;

public class GunAnim : MonoBehaviour {

    private Weapon weapon;
    private Animator anim;

	// Use this for initialization
	void Start () {
        weapon = FindObjectOfType<Weapon>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("Shoot", weapon.startTimer);
	}
}

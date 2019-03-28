using UnityEngine;
using System.Collections;

public class AIAnimator : MonoBehaviour {

    private AI ai;
    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponentInChildren<Animator>();
        ai = GetComponent<AI>();
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetInteger("ID", ai.stateID);
	}
}

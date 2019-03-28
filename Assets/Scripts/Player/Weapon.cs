using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    RaycastHit hit;
    Vector3 forward;

    public AudioClip shoot;

    public bool startTimer;
    public float timer;
    public float dur;

    private SFXManager sfxManage;

	// Use this for initialization
	void Start () {
        sfxManage = FindObjectOfType<Player>().GetComponent<SFXManager>();	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && !startTimer)
        {
            sfxManage.PlayClip(shoot);
            Shoot();
        }

        if (startTimer)
        {
            timer += Time.deltaTime;
        }

        if (timer >= dur)
        {
            startTimer = false;
            timer = 0.0f;
        }
	}

    public void Shoot()
    {
        forward = transform.TransformDirection(Vector3.forward) * 100;

        startTimer = true;

        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.collider.gameObject.CompareTag("AI"))
            {
                AI ai = hit.collider.gameObject.GetComponent<AI>();
                ai.hit = true;
            }
        }
    }
}

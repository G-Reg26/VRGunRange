using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

    private Player player;
    private BoxCollider collider;
    private SFXManager sfxManage;
    private ScoreKeeper sk;

    public Timer aiDur;
    public AudioClip shot;
    public Vector3 targetPoint;
    public Vector3 startingPoint;

    public int stateID;

    public bool hit;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
        sk = FindObjectOfType<ScoreKeeper>();
        collider = GetComponent<BoxCollider>();
        sfxManage = GetComponent<SFXManager>();

        startingPoint = transform.position;
        targetPoint = startingPoint + new Vector3 (0.0f, 3.0f, 0.0f);

        collider.enabled = false;

        aiDur.SetTimer(2.0f);

        stateID = 4;
	}
	
	// Update is called once per frame
	public void Update () {

        switch (stateID)
        {
            case 1:
                Rise();
                break;
            case 2:
                Wind();
                break;
            case 3:
                Retreat();
                break;
            case 4:
                Rest();
                break;
        }
    }

    void Rise()
    {
        if (transform.position != targetPoint)
            transform.position = Vector3.MoveTowards(transform.position, targetPoint, 30.0f * Time.deltaTime);
        else {
            aiDur.SetTimer(2.0f);
            stateID = 2;
        }
    }

    void Wind()
    {
        aiDur.start = true;
        collider.enabled = true;

        if (aiDur.timer <= 0.0f)
        {
            player.Shot();
            sfxManage.PlayClip(shot);

            collider.enabled = false;
            aiDur.start = false;
            stateID = 3;
        } else if (hit)
        {
            collider.enabled = false;
            aiDur.start = false;
            stateID = 3;
        }
    }

    void Retreat()
    {
        if (transform.position != startingPoint)
            transform.position = Vector3.MoveTowards(transform.position, startingPoint, 20.0f * Time.deltaTime);
        else {
            stateID = 4;
        }
    }

    void Rest()
    {
        transform.position = startingPoint;
        if (hit)
        {
            hit = false;
            sk.IncrementScore(10);
        }
    }
}

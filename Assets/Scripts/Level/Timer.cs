using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float timer;
    public bool start; 

	// Use this for initialization
	void Start () {
        start = false;  
	}
	
	// Update is called once per frame
	void Update () {
	    if (start)
        {
            CountDown();
        }
	}

    void CountDown()
    {
        timer -= Time.deltaTime;
    }

    public void SetTimer(float dur)
    {
        timer = dur;
    }
}

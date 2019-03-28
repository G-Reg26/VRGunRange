using UnityEngine;
using System.Collections;

public class LevelTimer : MonoBehaviour {

    private WaveManager wManage;
    private Countdown countDown;
    public Timer timer;

    public int minutes;

    public string seconds;

    // Use this for initialization
    void Start () {
        wManage = FindObjectOfType<WaveManager>();
        countDown = FindObjectOfType<Countdown>();

        //timer.SetTimer(59.0f);
	}
	
	// Update is called once per frame
	void Update () {
        if (timer.timer < 9.5)
            seconds = "0" + timer.timer.ToString("N0");
        else
            seconds = timer.timer.ToString("N0");

        if (timer.timer < 0.0f)
        {
            if (minutes == 0)
            {
                timer.SetTimer(0.0f);
                timer.start = false;

                countDown.timer.SetTimer(3.0f);

                countDown.stateID = 2;
                wManage.stateID = 0;
            }
            else
            {
                timer.SetTimer(59.0f);
                minutes -= 1;
            }
        }
    }  
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    private WaveManager wManage;
    private LevelManager lvlManager;
    private LevelTimer lvlTimer;

    public Timer timer;
    public Text countDownDisplay;
    public Text display;

    public int stateID;
    
	// Use this for initialization
	void Start () {
        wManage = FindObjectOfType<WaveManager>();
        lvlManager = FindObjectOfType<LevelManager>();
        lvlTimer = FindObjectOfType<LevelTimer>();

        display.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	    switch (stateID)
        {
            case 0:
                break;
            case 1:
                CountDownBegin();
                break;
            case 2:
                CountDownEnd();
                break;
        }
	}

    public void StartCount()
    {
        timer.SetTimer(5.0f);
        stateID = 1;
    }

    void CountDownBegin()
    {
        timer.start = true;

        if (timer.timer <= 0.0f)
        {
            countDownDisplay.enabled = false;
            display.enabled = true;

            lvlTimer.timer.start = true;
            timer.start = false;

            wManage.stateID = 1;
            stateID = 0;
        }
    }

    void CountDownEnd()
    {
        timer.start = true;

        countDownDisplay.enabled = true;
        display.enabled = false;

        if (timer.timer <= 0.0f)
        {
            timer.start = false;
            lvlManager.LoadNextScene();
        }
    }
}

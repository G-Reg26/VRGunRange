using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownDisplay : MonoBehaviour {

    private Countdown countDown;
    private Text countDownText;

	// Use this for initialization
	void Start () {

        countDownText = GetComponent<Text>();
        countDown = FindObjectOfType<Countdown>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (countDown.stateID == 1)
        {
            if (countDown.timer.timer >= 0.5f)
                countDownText.text = "Ready?\n" + countDown.timer.timer.ToString("N0");
            else
                countDownText.text = "START!!!";
        } else if (countDown.stateID == 2)
        {
            countDownText.text = "LEVEL END\n" + countDown.timer.timer.ToString("N0");
        }
	}
}

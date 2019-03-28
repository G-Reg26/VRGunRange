using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MonitorDisplay : MonoBehaviour {

    private LevelTimer lvlTimer;
    private ScoreKeeper sk;
    private Text text;

	// Use this for initialization
	void Start () {
        lvlTimer = FindObjectOfType<LevelTimer>();
        sk = FindObjectOfType<ScoreKeeper>();
        text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

        text.text = "Score: " + sk.score + "\n" +
                    "Time: " + lvlTimer.minutes + ":" + lvlTimer.seconds;
	}
}

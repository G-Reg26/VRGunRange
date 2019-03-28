using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TakeScore : MonoBehaviour {

    public int score;

    private Text scoreDisplay;

	// Use this for initialization
	void Start () {
        ScoreKeeper sk = FindObjectOfType<ScoreKeeper>();
        scoreDisplay = GetComponent<Text>();
        score = sk.score;
        Destroy(sk.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        scoreDisplay.text = "Score\n" + score;
    }
}

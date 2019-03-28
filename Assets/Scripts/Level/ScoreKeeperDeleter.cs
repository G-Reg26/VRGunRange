using UnityEngine;
using System.Collections;

public class ScoreKeeperDeleter : MonoBehaviour {

    public ScoreKeeper[] scoreKeeper;

    // Use this for initialization
    void Start()
    {
        scoreKeeper = FindObjectsOfType<ScoreKeeper>();

        if (scoreKeeper.Length > 1)
        {
            Delete();
            Reset();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Delete()
    {
        for (int i = 1; i < scoreKeeper.Length; i++)
        {
            Destroy(scoreKeeper[i].gameObject);
        }
    }

    void Reset()
    {
        scoreKeeper[0].score = 0;
    }
}

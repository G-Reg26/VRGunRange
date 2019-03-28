using UnityEngine;
using System.Collections;

public class WaveManager : MonoBehaviour {

    public AI[] ai;
    public Timer waitTimer;

    public int amountToSpawn;
    public int[] aiID;

    public int stateID;

	// Use this for initialization
	void Start () {
        ai = FindObjectsOfType<AI>();
        
        stateID = 0;
	}
	
	// Update is called once per frame
	void Update () {
        switch (stateID)
        {
            case 0:
                break;
            case 1:
                WaitTimer();
                break;
            case 2:
                SetTimer();
                SpawnAI();
                break;
            case 3:
                CheckBoard();
                break;
        }
	}

    void WaitTimer()
    {
        waitTimer.start = true;

        if (waitTimer.timer <= 0)
        {
            waitTimer.start = false;
            stateID = 2;
        }
    }

    void SetTimer()
    {
        waitTimer.SetTimer(3.0f);
    }

    void SpawnAI()
    {
        amountToSpawn = Random.Range(1, 4);

        for (int i = 0; i < amountToSpawn; i++)
        {
            aiID[i] = Random.Range(0, 6);

            if (i > 0)
            {
                do
                {
                    aiID[i] = Random.Range(0, 6);
                } while (aiID[i] == aiID[i - 1]);
            }
        }

        for (int i = 0; i < amountToSpawn; i++)
        {
            ai[aiID[i]].stateID = 1;
        }

        stateID = 3;
    }

    void CheckBoard()
    {
        int amountAtRest = 0;

        for (int i = 0; i < ai.Length; i++)
        {
            if (ai[i].stateID == 4)
            {
                amountAtRest++;
            }
        }

        if (amountAtRest == ai.Length)
        {
            stateID = 1;
        } else
        {
            amountAtRest = 0;
        }
    }
}

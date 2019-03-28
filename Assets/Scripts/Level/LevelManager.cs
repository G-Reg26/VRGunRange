using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    int currentIndex;
    public int newIndex;

    // Use this for initialization
    void Start () {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void LoadScene(int newIndex)
    {
        SceneManager.LoadScene(newIndex);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(currentIndex - 1);
    }
}

using UnityEngine;
using System.Collections;

public class ReticleScale : MonoBehaviour {

    private RectTransform imageTransform;

	// Use this for initialization
	void Start () {
        imageTransform = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void IncreaseSize()
    {
        imageTransform.sizeDelta = Vector2.Lerp(imageTransform.sizeDelta, new Vector2(6.25f, 6.25f), 10.0f * Time.deltaTime);
    }

    public void DecreaseSize()
    {
        imageTransform.sizeDelta = Vector2.Lerp(imageTransform.sizeDelta, new Vector2(3.125f, 3.125f), 10.0f * Time.deltaTime);
    }
}

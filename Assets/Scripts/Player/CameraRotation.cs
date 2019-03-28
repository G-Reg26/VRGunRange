using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

    public Transform body;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y") * -1;

        body.transform.rotation *= Quaternion.Euler(0.0f, mouseX, 0.0f);
        transform.rotation *= Quaternion.Euler(mouseY, 0.0f, 0.0f);
    }
}

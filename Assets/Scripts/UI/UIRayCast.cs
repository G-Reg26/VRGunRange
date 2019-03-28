using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIRayCast : MonoBehaviour {

    private RaycastHit hit;
    private ReticleScale reticle;
    private UnityEngine.EventSystems.BaseEventData eventData;
    private Button button;

    public LayerMask whatIsButton;

    Vector3 forward;

    // Use this for initialization
    void Start () {
        reticle = FindObjectOfType<ReticleScale>();
	}
	
	// Update is called once per frame
	void Update () {

        forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, forward, out hit, 250, whatIsButton))
        {
            button = hit.transform.GetComponent<Button>();

            button.OnSelect(eventData);
            reticle.IncreaseSize();

            if (Input.GetButtonDown("Fire1"))
            {
                reticle.DecreaseSize();
                button.onClick.Invoke();
                button = null;
            }
        }
        else
        {
            CheckCurrentButton();
        }

        Debug.DrawRay(transform.position, forward * 10, Color.green);
	}

    void CheckCurrentButton()
    {
        if (button != null)
        {
            Debug.Log("Unselected");
            button.OnDeselect(eventData);
            reticle.DecreaseSize();
            button = null;
        }
    }
}

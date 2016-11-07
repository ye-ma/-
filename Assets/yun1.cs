using UnityEngine;
using System.Collections;

public class yun1 : MonoBehaviour {
    private Vector3 screenPoint;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.touches[0].position.x  >Screen.width / 2)
        {



            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                screenPoint = Camera.main.WorldToScreenPoint(transform.position);
                offset = transform.position -
             Camera.main.ScreenToWorldPoint(new Vector3(
                                                              Input.touches[0].position.x,
                                                              Input.touches[0].position.y,
                                                              screenPoint.z));






            }

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Vector3 curScreenPoint = new Vector3(Input.touches[0].position.x,
                                                     Input.touches[0].position.y,
                                                     screenPoint.z);

                Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
                curPosition.z = transform.position.z;
                gameObject.transform.position = curPosition;
            }
        }

    }
}

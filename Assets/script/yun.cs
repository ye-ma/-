using UnityEngine;
using System.Collections;

public class yun : MonoBehaviour {
    public GameObject gameobject;

    public GameObject cameras;
    // Use this for initialization
    void Start () {
      cameras= GameObject.Find("2destroypoint");

    }
	
	// Update is called once per frame
	void Update () {
        if (gameobject.transform.position.y < cameras.transform.position.y) {

            Destroy(this.gameobject);


        }
	}
}

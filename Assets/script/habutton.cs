using UnityEngine;
using System.Collections;

public class habutton : MonoBehaviour {
    public GameObject a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void appear() {
        a.SetActive(true);
    }

    public void disappear()
    {
        a.SetActive(false);
    }


}

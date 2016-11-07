using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gamemanage : MonoBehaviour {
    public GameObject player;
    public GameObject ab;
    public GameObject platform;

    public GameObject point;
    public GameObject camera2;
    // Use this for initialization

    void Start() {
     
    }


    public void appear()
    {
        ab.SetActive(true);
        



    }

    public void disappear()
    {
        ab.SetActive(false);



    
    
        SceneManager.LoadScene(1);
    





}


}
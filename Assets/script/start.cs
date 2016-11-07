using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {



    // Update is called once per frame
    public  void aa(int a) {
        SceneManager.LoadScene(a);
    }
}

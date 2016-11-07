using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class loading : MonoBehaviour {

    // Use this for initialization
    AsyncOperation async;

    private float time;


    private int nowFram;



    private object animations;

    void Start()
    {
        StartCoroutine(loadScene(2));
    }
    // Update is called once per frame

    IEnumerator loadScene(int a)

    {

        //异步读取场景。

        //Globe.loadName 就是A场景中需要读取的C场景名称。



        async = SceneManager.LoadSceneAsync(a);

        //读取完毕后返回， 系统会自动进入C场景

        yield return async;



    }
   

   
    

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageControl : MonoBehaviour
{
    [SerializeField] GameObject sumaho;
    private void Start()
    {
     
    }

    void Update()
    {
        //Xキーを押す
        if (Input.GetKeyDown(KeyCode.X))
        {
            //ゲームオブジェクト表示→非表示
            sumaho.SetActive(false);
        }
        //Zキーを押す
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //ゲームオブジェクト非表示→表示
            sumaho.SetActive(true);
        }
    }
}

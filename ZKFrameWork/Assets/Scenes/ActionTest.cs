using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActionTest : MonoBehaviour
{
    public Action _KeyTest;
    public Action A_key;
    // Start is called before the first frame update
    void Start()
    {
        A_key = BlindDebug;
        _KeyTest = BlindDebugA;
    }

    // Update is called once per frame
    void Update()
    {
        InpuKey();
    }

    public void InpuKey()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            KeyAction(callback: _KeyTest);
        }
    }

    public void KeyAction(Action callback)
    {
        callback();
    }

    public void BlindDebug()
    {
        Debug.Log("blindA");
    }


    public void BlindDebugA()
    {
        Debug.Log("blindA_KeyTest");
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGman : MonoBehaviour {

	// Use this for initialization

     [Header("對話")]
    public string Say = "早安你好";
    public float SaySpeed = 0.2f;

    [Header("任務")]
    public bool Complete = false;
    public int Batery, BateryFinish = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    /// <summary>
    /// 給他一個浮點數名Speed
    /// 註解"移動"
    /// 控制速度
    /// </summary>
    [Header("移動")]
    [Range(0, 5)] public float Speed;
    /// <summary>
    /// 給他一個浮點數名Speed
    /// 註解"跳躍"
    /// 控制跳的高度
    /// </summary>
    [Header("跳躍")]
    [Range(0, 100)] public float JumpForce;

    float Timer;
    public bool isGround = false;
    Rigidbody rgbdy;
    // Use this for initialization
    void Start () {

        rgbdy = this.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
    /// <summary>
    /// 按下按鍵後執行的事
    /// </summary>
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, Speed * 1, Space.Self);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -Speed * 1, Space.Self);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Speed * 1, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-Speed * 1, 0, 0, Space.Self);
        }
        if (isGround == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Jump();
            }
        }
    }
    /// <summary>
    /// 解釋Jump功能
    /// </summary>
    public void Jump()
    {
        rgbdy.AddForce(Vector3.up * JumpForce);
        isGround = false;
    }
    void OnCollisionStay(Collision other)
    {
        isGround = true;
    }
}
	

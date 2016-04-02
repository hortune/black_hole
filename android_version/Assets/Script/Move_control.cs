﻿using UnityEngine;
using System.Collections;

public class Move_control : MonoBehaviour {
    private float move_cof;
    public Rigidbody me;
    public Transform mee;
    private Vector3 pos;

	// Use this for initialization
	void Start () {
        move_cof = 20f;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetKey(KeyCode.W))
            me.AddForce(transform.up * move_cof);
        if (Input.GetKey(KeyCode.A))
            me.AddForce(transform.right * move_cof);
        if (Input.GetKey(KeyCode.S))
            me.AddForce(-transform.up * move_cof);
        if (Input.GetKey(KeyCode.D))
            me.AddForce(-transform.right * move_cof);
            */

        pos = mee.position;

        if (Input.acceleration.y>0)
            pos.z -= Time.deltaTime * move_cof;
        if (Input.acceleration.x<0)
            pos.x += Time.deltaTime * move_cof;
        if (Input.acceleration.y<0)
            pos.z += Time.deltaTime * move_cof;
        if (Input.acceleration.x>0)
            pos.x -= Time.deltaTime * move_cof;

        mee.position = pos;
    }
}






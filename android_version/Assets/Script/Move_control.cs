using UnityEngine;
using System.Collections;

public class Move_control : MonoBehaviour
{
    public float move_cof;
    public float PC_move_cof;
    public Rigidbody me;
    public Transform mee;
    private Vector3 pos;

    // Use this for initialization
    void Start()
    {
        move_cof = 1.0f;
        PC_move_cof = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        //This is for PC control (force)
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

        //This is for PC control (pos)
        pos = mee.position;

        if (Input.GetKey(KeyCode.W))
            pos.z -= Time.deltaTime * PC_move_cof;
        if (Input.GetKey(KeyCode.A))
            pos.x += Time.deltaTime * PC_move_cof;
        if (Input.GetKey(KeyCode.S))
            pos.z += Time.deltaTime * PC_move_cof;
        if (Input.GetKey(KeyCode.D))
            pos.x -= Time.deltaTime * PC_move_cof;

        mee.position = pos;
        

        //This is for android control

        
        pos = mee.position;

       
            pos.z -= Input.acceleration.y * move_cof;
            pos.x -= Input.acceleration.x * move_cof;

        mee.position = pos;
        
    }
}






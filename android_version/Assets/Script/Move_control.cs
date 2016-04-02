using UnityEngine;
using System.Collections;


/*public class Move_control : MonoBehaviour {
    private float move_cof;
    public Rigidbody me;

	// Use this for initialization
	void Start () {
        move_cof = 40f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            me.AddForce(transform.up * move_cof);
        if (Input.GetKey(KeyCode.A))
            me.AddForce(transform.right * move_cof);
        if (Input.GetKey(KeyCode.S))
            me.AddForce(-transform.up * move_cof);
        if (Input.GetKey(KeyCode.D))
            me.AddForce(-transform.right * move_cof);
    }
}*/




[RequireComponent(typeof(CharacterController))]



public class Move_control : MonoBehaviour
{
    private float move_cof;
    public Rigidbody me;
    private CharacterController controller;
    private Vector3 direction; //方向
    public float speed = 40.0f; //速度


    void Start()
    {
        //controller = GetComponent<CharacterController>();
        direction = Vector3.zero;
    }

    void Update()
    {
        direction.x = Input.acceleration.x;
        direction.y = Input.acceleration.y;
        me.AddForce(transform.up *speed* Input.acceleration.y);
        me.AddForce(-transform.right*speed*Input.acceleration.x);
        //controller.Move(direction * speed * Time.deltaTime);
    }
}
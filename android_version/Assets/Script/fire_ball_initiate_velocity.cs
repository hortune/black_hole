using UnityEngine;
using System.Collections;

public class fire_ball_initiate_velocity : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject me;
    public static float k = 0.01f;
    void Start()
    {
       
        Vector3 qaq=new Vector3(k,k,k);
        rb.velocity=Vector3.Scale((rb.position-me.transform.position),qaq);
        k += 0.01f;
    }
}
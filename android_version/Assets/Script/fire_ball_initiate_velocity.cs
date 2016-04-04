using UnityEngine;
using System.Collections;

public class fire_ball_initiate_velocity : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject me;
    public static float k = 0.01f;
    void Start()
    {
        
        Vector3 qaq=new Vector3(Random.Range(0, 1)* k, Random.Range(0,1)*k,Random.Range(0,1)*k);
        rb.velocity=Vector3.Scale((rb.position-me.transform.position),qaq);
        k += 0.01f;
    }
}
using UnityEngine;
using System.Collections;

public class fire_ball_initiate_velocity : MonoBehaviour
{
    //when fire_ball is instatiate,give it a velocity toward "Me"

    public Rigidbody rb;
    public GameObject me;
    public static float k = 0.01f;
    void Start()
    {
        Vector3 qaq = new Vector3(Random.Range(0, 1) * k, 1f, Random.Range(0, 1) * k);
        rb.velocity = Vector3.Scale((rb.position - me.transform.position), qaq);
        k += 0.01f;
    }
}
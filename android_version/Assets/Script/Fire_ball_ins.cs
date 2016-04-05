using UnityEngine;
using System.Collections;
public class Fire_ball_ins : MonoBehaviour
{
    public GameObject fire_ball;
    public GameObject potion;
    public GameObject venom;
    public GameObject star;

    public Transform charc;
    public float timer, timer_save;
    private Vector3 pos;
    public static int fire_ball_amount_restrict;
    public static int fire_ball_amount;
    // Use this for initialization
    void Start()
    {
        fire_ball_amount_restrict = 20;
        fire_ball_amount = 0;
        timer = 0.5f;
        timer_save = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0f && fire_ball_amount <= fire_ball_amount_restrict)
            timer -= Time.deltaTime;
        else
        {
            GameObject tmp;
            Rigidbody tmp_rb;

            fire_ball_amount++;
            timer = timer_save;

            if (timer_save > 0.3f)
                timer_save *= 0.85f;

            int r = Random.Range(0, 100);
            if (100 >= r && r > 28)
            {
                tmp = Instantiate(fire_ball, gameObject.transform.position, Quaternion.identity) as GameObject;
                tmp_rb = tmp.GetComponent<Rigidbody>();
                tmp_rb.AddForce(new Vector3(Random.Range(100, 200f), 0f, Random.Range(100, 200f)));
            }
            else if (28 >= r && r > 14)
            {
                tmp = Instantiate(star, gameObject.transform.position, Quaternion.identity) as GameObject;
                tmp_rb = tmp.GetComponent<Rigidbody>();
                tmp_rb.AddForce(new Vector3(Random.Range(100, 200f), 0f, Random.Range(100, 200f)));
            }
            else if (14 >= r && r > 7)
            {
                tmp = Instantiate(venom, gameObject.transform.position, Quaternion.identity) as GameObject;
                tmp_rb = tmp.GetComponent<Rigidbody>();
                tmp_rb.AddForce(new Vector3(Random.Range(100, 200f), 0f, Random.Range(100, 200f)));
            }
            else
            {
                tmp = Instantiate(potion, gameObject.transform.position, Quaternion.identity) as GameObject;
                tmp_rb = tmp.GetComponent<Rigidbody>();
                tmp_rb.AddForce(new Vector3(Random.Range(100, 200f), 0f, Random.Range(100, 200f)));
            }
        }
    }
}

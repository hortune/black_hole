using UnityEngine;
using System.Collections;

public class White_hole_ins : MonoBehaviour {
    public GameObject white_hole;
    private Vector3 pos;
    public static float timer, timer_save;
    public static int white_hole_amount_restriction = 5;
    public static int white_hole_amount = 0;
    void Start()
    {
        timer = 5f;
        timer_save = timer;
    }

    void Update()
    {
        if (timer >= 0f || white_hole_amount_restriction< white_hole_amount)
            timer -= Time.deltaTime;
        else
        {
            white_hole_amount++;
            pos = new Vector3(Random.Range(-47f, 47f), 1f, Random.Range(-47f, 47f));
            Instantiate(white_hole, pos, Quaternion.identity);

            timer = timer_save;
            timer_save *= 0.9f;
        }
    }
}

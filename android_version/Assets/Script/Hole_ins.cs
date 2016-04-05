using UnityEngine;
using System.Collections;

public class Hole_ins : MonoBehaviour {
    public GameObject white_hole;
    public GameObject black_hole;

    public static float w_h_delay, w_h_delay_save;
    public static float b_h_delay, b_h_delay_save;

    [SerializeField] public static int white_hole_amount_restriction;
    [SerializeField] public static int white_hole_amount;

    [SerializeField] public static int black_hole_amount_restriction;
    [SerializeField] public static int black_hole_amount;

    // Use this for initialization
    public void Start()
    {
        w_h_delay = 3f;
        w_h_delay_save = 2f;

        b_h_delay = 2f;
        b_h_delay_save = 1.5f;

        white_hole_amount_restriction = 5;
        white_hole_amount = 0;

        black_hole_amount_restriction = 5;
        black_hole_amount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (w_h_delay >= 0f && white_hole_amount < white_hole_amount_restriction)
            w_h_delay -= Time.deltaTime;
        if (b_h_delay >= 0f && black_hole_amount < black_hole_amount_restriction)
            b_h_delay -= Time.deltaTime;

        if (w_h_delay < 0f)
        {
            Vector3 pos = new Vector3(Random.Range(-47f, 47f), 1f, Random.Range(-47f, 47f));
            Instantiate(white_hole, pos, Quaternion.identity);

            white_hole_amount++;
            w_h_delay = w_h_delay_save;
        }
        if (b_h_delay < 0f)
        {
            Vector3 pos = new Vector3(Random.Range(-47f, 47f), 1f, Random.Range(-47f, 47f));
            Instantiate(black_hole, pos, Quaternion.identity);

            black_hole_amount++;
            b_h_delay = b_h_delay_save;
        }
    }
}

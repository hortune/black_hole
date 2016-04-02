using UnityEngine;
using System.Collections;

public class Destroy_fireball : MonoBehaviour {
    private int obj_obsorb;

    void Awake()
    {
        obj_obsorb = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Me")
        {
            Destroy(other.gameObject);
            obj_obsorb++;
            Check_D();
        }
    }

    void Check_D()
    {
        if (obj_obsorb > 4)
            Destroy(gameObject);
    }
}

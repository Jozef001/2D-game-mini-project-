using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heal : MonoBehaviour
{
    public Transform[] healpts;
    public GameObject[] masks;
    public float healinterval;
    public float startheal;
    public float decrease;
    public float minimumgap;
    public GameObject player;





    void Update()
    {
        if (player != null)
        {
            if (healinterval <= 0)
            {
                Transform randomhealpts = healpts[Random.Range(0, healpts.Length)];
                GameObject randommasks = masks[Random.Range(0, masks.Length)];
                Instantiate(randommasks, randomhealpts.position, Quaternion.identity);

                if (startheal > minimumgap)
                {
                    startheal -= decrease;
                }
                healinterval = startheal;
            }
            else
            {
                healinterval -= Time.deltaTime;
            }

        }

    }
}

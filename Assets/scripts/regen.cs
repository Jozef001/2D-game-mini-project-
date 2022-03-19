using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class regen : MonoBehaviour
{
    public Transform[] regeneratingpoints;
    public GameObject[] enemy;

    private float regenerationinterval;
    public float regeneratonstarttime;
    public float minimum_time_for_regeneration;
    public float decrease;
    public GameObject player;
    
    void Update()
    {
        if (player != null)
        {
            if (regenerationinterval <= 0)
            {
                Transform randomregenerationpoints = regeneratingpoints[Random.Range(0, regeneratingpoints.Length)];
                GameObject randomenemy = enemy[Random.Range(0, enemy.Length)];

                Instantiate(randomenemy, randomregenerationpoints.position, Quaternion.identity);

                if (regeneratonstarttime > minimum_time_for_regeneration)
                {
                    regeneratonstarttime = regeneratonstarttime - decrease;
                }
                regenerationinterval = regeneratonstarttime;
            }
            else
            {
                regenerationinterval = regenerationinterval - Time.deltaTime;
            }
        }
    }
}
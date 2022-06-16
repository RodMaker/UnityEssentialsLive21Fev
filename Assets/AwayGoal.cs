using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwayGoal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            other.GetComponent<Sphere>().AddScoreAway(1);
            Destroy(gameObject);
        }
    }
}

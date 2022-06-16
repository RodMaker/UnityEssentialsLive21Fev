using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            other.GetComponent<Sphere>().AddScore(1);
            Destroy(gameObject);
            //Sphere.TrackPosition();
            
            //other.GetComponent<Sphere>().TrackPosition();
            //other.GetComponent<NewKartClassicPlayer>().TrackPosition();
            
            // Destroy(gameObject);
            // SceneManager.LoadSceneAsync("Stadium1");
            
        }
    }
}

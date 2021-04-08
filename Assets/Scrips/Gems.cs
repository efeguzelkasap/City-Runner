using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Gems : MonoBehaviour
{
    AudioSource audioSource;
    ParticleSystem particle;
    Score score;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        particle = GetComponent<ParticleSystem>();
        score = FindObjectOfType<Score>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        particle.Play();
        score.addToScore();
        //Play pick gem up sound.
        //Play small particle effect.
        //Add to total number of gems score.
    }

    

    

}

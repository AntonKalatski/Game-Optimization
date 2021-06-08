using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHowl : MonoBehaviour
{
    public AudioSource wolf;
    public AudioSource wind;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wolf.Play();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            wind.Play();
        }
    }
}
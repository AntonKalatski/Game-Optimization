//Adapted from:
//https://gamedevbeginner.com/unity-audio-optimisation-tips/
using System.Collections;
using UnityEngine;

public class PlayerCanHear : MonoBehaviour
{
    private AudioListener player;
    private AudioSource thisSound;
    private float distanceFromPlayer;
    WaitForSeconds wfs;

    void Start()
    {
        player = Camera.main.GetComponent<AudioListener>();
        thisSound = gameObject.GetComponent<AudioSource>();
        wfs = new WaitForSeconds(Random.Range(0.5f,1.5f));

        StartCoroutine(AmIAudible());
    }

    IEnumerator AmIAudible()
    {
        while (true)
        {
            distanceFromPlayer = Vector3.Distance(transform.position, player.transform.position);

            if (distanceFromPlayer <= thisSound.maxDistance)
            {
                Playing(true);
            }
            else
            {
                Playing(false);
            }
            yield return wfs;
        }
    }

    void Playing(bool isAudible)
    {
        if (!isAudible && thisSound.isPlaying)
        {
            thisSound.Pause();
        }
        else if (isAudible && !thisSound.isPlaying)
        {
            thisSound.Play();
        }
    }
}

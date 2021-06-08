using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioClip : MonoBehaviour
{
    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            music.clip.LoadAudioData();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            music.Play();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            music.clip.UnloadAudioData();
        }
    }
}

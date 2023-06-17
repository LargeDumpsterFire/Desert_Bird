using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip birdChirp, windSound, randomnBirds, death;
    static AudioSource audioSrc;
    void Start()
    {
        birdChirp = Resources.Load<AudioClip>("robinChirp");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "birdFlap":
                audioSrc.PlayOneShot(birdChirp);
                break;
        }
    }
}

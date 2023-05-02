
using UnityEngine;


public class HumanSound : MonoBehaviour {
    public AudioSource audio;
    public void playSound()
    { 
         
        audio.GetComponent<AudioSource>().Play();
    }
}


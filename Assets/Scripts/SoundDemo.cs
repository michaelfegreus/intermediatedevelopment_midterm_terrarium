using UnityEngine;
using System.Collections;

public class SoundDemo : MonoBehaviour {

	public AudioSource myAudioSource;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			/*if (myAudioSource.isPlaying == false) {
				myAudioSource.Play ();
			}*/
			myAudioSource.PlayOneShot (myAudioSource.clip); // Plays a new instance of the sound each space bar. Does not interrupt.
		}
	}
}

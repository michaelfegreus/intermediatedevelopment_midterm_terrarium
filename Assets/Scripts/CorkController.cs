using UnityEngine;
using System.Collections;

public class CorkController : MonoBehaviour {

	public GameObject seed;
	SeedController sc;

	void OnTriggerEnter(Collider col){
		if (col.name == ("CorkTrigger")) {
			sc.
		}
	}

	// Use this for initialization
	void Start () {
		sc = seed.GetComponent<SeedController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

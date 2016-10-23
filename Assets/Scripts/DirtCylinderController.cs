using UnityEngine;
using System.Collections;

public class DirtCylinderController : MonoBehaviour {

	float scaleY = 7f;
	public float scaling;
	Renderer rend;

	void OnTriggerEnter(Collider col) {
		if (col.tag == ("Dirt")) {
			if (rend.enabled == false) {
				rend.enabled = true;
			}
			scaleY = scaleY + scaling;
			transform.localScale = new Vector3(51f, scaleY,51f);
		}
	}

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

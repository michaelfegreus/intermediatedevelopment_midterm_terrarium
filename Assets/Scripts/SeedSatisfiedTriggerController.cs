using UnityEngine;
using System.Collections;

public class SeedSatisfiedTriggerController : MonoBehaviour {

	SeedController sc;

	void OnTriggerEnter(Collider col) {
		if (col.name == ("DirtCylinder")) {
			sc = transform.parent.gameObject.GetComponent<SeedController> ();
			sc.dirtSatisfiedTrigger ();
		}
	}

}
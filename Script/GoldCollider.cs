using UnityEngine;
using System.Collections;

public class GoldCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider)
	{
		Debug.Log ("Hello");
		if (collider.gameObject.name == "AngryBall") {
			Destroy(this.gameObject);
		}


		
	}
}

using UnityEngine;
using System.Collections;

public class FailCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider collider)
	{

		if (collider.gameObject.name == "AngryBall") {
			Time.timeScale=0;
			Debug.Log("Fail");
		}
		
		
		
	}
}

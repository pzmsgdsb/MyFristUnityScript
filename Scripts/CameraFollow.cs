using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform target;
	public float height = 3f;
	public float distance = 4f;

	public float damping = 20f;

	float currentX = 0;
	float currentY = 0;

	Vector3 startPos;
	// Use this for initialization
	void Start () {
//		startPos = target.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		currentX = Mathf.Lerp(currentX,height,damping*Time.deltaTime);
		currentY = Mathf.Lerp(currentY,distance,damping*Time.deltaTime);

		transform.position =target.position + new Vector3(0,currentX,-currentY);
		transform.LookAt(target);
	}
}

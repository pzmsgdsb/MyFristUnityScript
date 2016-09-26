using UnityEngine;
using System.Collections;

public class RailRotate : MonoBehaviour {
	public float rotateSpeed=6.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3 (0, rotateSpeed * Time.deltaTime, 0),Space.World);
	}
}

using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {

	public CharacterController c;
	public Animation animation;
	public EasyJoystick joy;
	private Vector3 moveDirection = Vector3.zero;
	public float moveSpeed = 5.0f;
	public float pushPower = 2.0F;
	private bool isGrand;
	// Use this for initialization
	void Start () {
		c = this.GetComponent<CharacterController> ();
		animation = this.GetComponent<Animation> ();

	}
	
	// Update is called once per frame
	void Update () {
		float x = joy.JoystickTouch.x ;
		float z = joy.JoystickTouch.y ; 
		if (x != 0 || z != 0) {
			transform.LookAt (new Vector3 (transform.position.x+x, 
		                             transform.position.y, 
		                             transform.position.z + z)); 

			moveDirection = transform.TransformDirection (Vector3.forward);
			moveDirection = moveDirection * 4.0f * Time.deltaTime;
			if (!isGrand) {
				moveDirection.y -= 9.8f * Time.deltaTime;
			}
			CollisionFlags flgs = c.Move (moveDirection);//根据flgs的值可以判断  控制是否碰触 地 也可以 下 的c.isGrounded来判断。
			GetComponent<Animation>().CrossFade("Run",0.5f);
			// //
			isGrand = c.isGrounded;

		} else {
			GetComponent<Animation>().CrossFade("Idle",0.5f);
		}

	}

	void OnControllerColliderHit(ControllerColliderHit hit) { 
		Debug.Log("Hit");
//		Rigidbody body = hit.collider.attachedRigidbody; 
//		if (body == null || body.isKinematic)
//			return;
//		if (hit.moveDirection.y < -0.3F)
//			return;
//		Vector3 pushDir = new Vector3(hit.moveDirection.x, 0,
//		                              hit.moveDirection.z);
//		body.velocity = pushDir * pushPower;
	} 
}


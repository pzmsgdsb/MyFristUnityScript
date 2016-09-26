using UnityEngine;
using System.Collections;

public class OldAnimation : MonoBehaviour {

	// Use this for initialization
	private float scaleW=1.0f;
	private float scaleH=1.0f;
	public AnimationClip _idle;
	public AnimationClip _attack;
	public AnimationClip _defend;
	public AnimationClip _jump;
	public AnimationClip _run;
	public AnimationClip _die;

	void Start () {
	
		GetComponent<Animation> ()[_idle.name].enabled = true;
		GetComponent<Animation> ()[_idle.name].layer = 1;

		GetComponent<Animation>()[_attack.name].enabled = true;
		GetComponent<Animation>()[_attack.name].layer = 1;
		
		GetComponent<Animation>()[_defend.name].enabled = true;
		GetComponent<Animation>()[_defend.name].layer = 1;


		
		GetComponent<Animation>()[_run.name].enabled = true;
		GetComponent<Animation>()[_run.name].layer = 1;

		GetComponent<Animation>()[_jump.name].enabled = true;
		GetComponent<Animation>()[_jump.name].layer = 1;

		GetComponent<Animation>()[_die.name].enabled = true;
		GetComponent<Animation>()[_die.name].layer = 1;

//		Animation animation = this.GetComponent<Animation> ();
//		animation.Play ("Attack");

	}

	void Update()
	{
		scaleW =(float) Screen.width / 800;
		scaleH = (float)Screen.height / 480;

		if (!GetComponent<Animation> ().isPlaying) {
			GetComponent<Animation>().CrossFade(_idle.name,0.5f);
		}

	}

	void OnGUI()
	{

		GUI.skin.button.fontSize = (int)(25 * scaleW);

		if (GUI.Button (new Rect (70 * scaleW, 50 * scaleH, 90 * scaleW, 40 * scaleH), "Stand"))
		{
			GetComponent<Animation>().CrossFade(_idle.name,0.5f);
		}

		if (GUI.Button (new Rect (70 * scaleW, 110 * scaleH, 90 * scaleW, 40 * scaleH), "Attack"))
		{
			GetComponent<Animation>().CrossFade(_attack.name,0.5f);
		}

		if (GUI.Button (new Rect (70 * scaleW, 170 * scaleH, 90 * scaleW, 40 * scaleH), "Defend"))
		{
			GetComponent<Animation>().CrossFade(_defend.name,0.5f);
		}

		if (GUI.Button (new Rect (70 * scaleW, 230 * scaleH, 90 * scaleW, 40 * scaleH), "Jump"))
		{
			GetComponent<Animation>().CrossFade(_jump.name,0.5f);
		}

		if (GUI.Button (new Rect (70 * scaleW, 290 * scaleH, 90 * scaleW, 40 * scaleH), "Run"))
		{
			GetComponent<Animation>().CrossFade(_run.name,0.5f);
		}

		if (GUI.Button (new Rect (70 * scaleW, 350 * scaleH, 90 * scaleW, 40 * scaleH), "Die"))
		{
			GetComponent<Animation>().CrossFade(_die.name,0.5f);
		}


	}

}

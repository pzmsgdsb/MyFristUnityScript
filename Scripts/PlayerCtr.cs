using UnityEngine;
using System.Collections;

public class PlayerCtr : MonoBehaviour {
    [SerializeField]
    private EasyJoystick joyStick;

    private StateMachine m_StateMachine;

    public Animation ani;
	// Use this for initialization
	void Start () {
        //初始状态机
        m_StateMachine = new StateMachine(new IdleState(0, this));
        InitState();
       
	}

    void InitState()
    {
        m_StateMachine.RegisterState(new RunState(1,this));
    }
	
    
	// Update is called once per frame
	void Update () {
        float x = joyStick.JoystickTouch.x;
        float z = joyStick.JoystickTouch.y;

        if (x != 0 || z != 0)
        {
            transform.LookAt(new Vector3(x,0,z) + transform.position);
            m_StateMachine.TranslateToState(1);
        }
	}

    void LateUpdate()
    {
        m_StateMachine.FSMUpdate();
    }

    void OnDrag(Vector2 delta)
    {
        Debug.Log(delta);
        transform.Rotate(-Vector3.up*delta.normalized.x*10f);
    }
}

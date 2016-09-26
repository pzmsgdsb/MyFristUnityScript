using UnityEngine;
using System.Collections;

public enum StateID : int
{
    Idle = 0,
    Run
}

public class IdleState : StateTemplate<PlayerCtr> {

    public IdleState(int id,PlayerCtr owner):base(id,owner)
    {
 
    }
    public override void OnEnter(params object[] args)
    {
        base.OnEnter(args);
        Debug.Log("IdleState Enter");
        m_owner.ani.Play("Idle");
    }

    public override void OnStay(params object[] args)
    {
        base.OnStay(args);
    }

    public override void OnExit(params object[] args)
    {
        base.OnExit(args);
        Debug.Log("IdleState OnExit");
    }
}

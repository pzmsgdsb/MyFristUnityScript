using UnityEngine;
using System.Collections;

public class RunState  : StateTemplate<PlayerCtr> {

    public RunState(int id,PlayerCtr owner):base(id,owner)
    {
        
    }

    public override void OnEnter(params object[] args)
    {
        base.OnEnter(args);
        Debug.Log("RunState Enter");
        m_owner.ani.Play("Run");
    }

    public override void OnStay(params object[] args)
    {
        base.OnStay(args);
    }

    public override void OnExit(params object[] args)
    {
        base.OnExit(args);
        Debug.Log("RunState OnExit");
    }
}

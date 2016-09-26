using UnityEngine;
using System.Collections;

/// <summary>
/// 状态基类
/// </summary>
public abstract class StateBase {
    /// <summary>
    /// 每个状态对应不同的ID号
    /// </summary>
    public int ID { get; private set; }

    /// <summary>
    /// 状态机
    /// </summary>
    public StateMachine machine;

    /// <summary>
    /// Construtor
    /// </summary>
    /// <param name="id">状态的id号(id号有对应的枚举)</param>
    public StateBase(int id)
    {
        ID = id;
    }
    
    /// <summary>
    /// 状态进入时调用一次
    /// </summary>
    public virtual void OnEnter(params object[] args)
    { }
    /// <summary>
    /// 状态退出时调用一次
    /// </summary>
    public virtual void OnExit(params object[] args)
    { }
    /// <summary>
    /// 状态进入后，每帧调用一次
    /// </summary>
    public virtual void OnStay(params object[] args)
    { }
}

using UnityEngine;
using System.Collections;
/// <summary>
/// 状态模板
/// </summary>
public class StateTemplate<T> :StateBase {
    /// <summary>
    /// 状态的拥有者
    /// </summary>
    public T m_owner;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="id">状态的id号</param>
    /// <param name="owner">状态的拥有者</param>
    public StateTemplate(int id,T owner):base(id)
    {
        m_owner = owner;
    }


}

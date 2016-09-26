using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// 状态机
/// </summary>
public class StateMachine{
    /// <summary>
    /// 状态缓存
    /// </summary>
    public Dictionary<int, StateBase> m_StateCache;

    /// <summary>
    /// 当前状态
    /// </summary>
    public StateBase m_CurrentState;
    /// <summary>
    /// 当前状态的前一个状态
    /// </summary>
    public StateBase m_PreviousState;

    #region StateMachine  Constructor
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="beginState">开始状态</param>
    public StateMachine(StateBase beginState)
    {
        m_PreviousState = null;
        m_CurrentState = beginState;
        m_StateCache = new Dictionary<int, StateBase>();
        //注册状态
        RegisterState(beginState);
        m_CurrentState.OnEnter();
    }
    #endregion

    #region FSMUpdate  状态机监测状态
    /// <summary>
    /// 状态机监测状态变化
    /// </summary>
    public void FSMUpdate()
    {
        if (m_CurrentState != null)
            m_CurrentState.OnStay();
    }
    #endregion

    #region TranslateToState 状态切换
    /// <summary>
    /// 状态切换
    /// </summary>
    /// <param name="id">目标状态的id号</param>
    /// <param name="args">可变参数</param>
    public void TranslateToState(int id,params object[] args)
    {
        int key_id = id;
        if (!m_StateCache.ContainsKey(key_id))
        {
            Debug.LogError("The key is not Exist");
            return;
        }
        //当前状态退出
        m_CurrentState.OnExit();
        //保存当前状态为下一个新状态的前一个状态
        m_PreviousState = m_CurrentState;
        //当前状态更新到下一个新状态
        m_CurrentState = m_StateCache[key_id];
        //新的状态开始进入
        m_CurrentState.OnEnter(args);
    }
    #endregion

    #region RegisterState   注册一个新的状态到缓存中
    /// <summary>
    /// 注册一个新的状态到缓存中
    /// </summary>
    /// <param name="aState">新状态</param>
    public void RegisterState(StateBase aState)
    {
        int id = aState.ID;
        //状态是否缓存了
        if (m_StateCache.ContainsKey(id))
        {
            Debug.LogError("The State has been added the Cache");
            return;
        }
        //缓存aState状态
        m_StateCache.Add(id,aState);
        //设置aState状态的状态机对象
        aState.machine = this;
    }
    #endregion


}

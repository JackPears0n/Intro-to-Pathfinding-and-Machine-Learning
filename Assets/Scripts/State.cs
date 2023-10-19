using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    protected PlayerMoveScript pms;

    protected StateMachine sm;


    //Player status variables
    public Idle idleS;
    public Walking walikingS;
    public Running runningS;
    public Attacking attackingS;

    //Constructor for the base
    protected State(PlayerMoveScript pms, StateMachine sm)
    {
        this.pms = pms;
        this.sm = sm;
    }

    #region Common Methods
    public virtual void Enter()
    {
        //Debug.Log("This is base.enter");
    }

    public virtual void HandleInput()
    {
    }

    public virtual void LogicUpdate()
    {
    }

    public virtual void PhysicsUpdate()
    {
    }

    public virtual void Exit()
    {
    }
    #endregion
}

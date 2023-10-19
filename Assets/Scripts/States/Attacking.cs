using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : State
{
    public Attacking(PlayerMoveScript player, StateMachine sm) : base(player, sm)
    {
    }

    public override void Enter()
    {
        base.Enter();
        pms.anim.Play("Male Attack 1");
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void HandleInput()
    {
        base.HandleInput();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        pms.CheckForIdle();
        pms.CheckForWalk();

    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}

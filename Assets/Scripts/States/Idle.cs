using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : State
{
    public Idle(PlayerMoveScript player, StateMachine sm) : base(player, sm)
    {
    }
    public override void Enter()
    {
        base.Enter();
        pms.anim.Play("Male Idle");
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

        pms.CheckForWalk();
        pms.CheckForAttack();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}

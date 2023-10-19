using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : State
{
    public Running(PlayerMoveScript player, StateMachine sm) : base(player, sm)
    {
    }
    public override void Enter()
    {
        base.Enter();
        pms.anim.Play("Walk to Run BT");
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
        pms.CheckForIdle();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}

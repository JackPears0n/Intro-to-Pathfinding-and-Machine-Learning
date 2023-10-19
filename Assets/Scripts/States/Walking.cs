using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : State
{
    public Walking(PlayerMoveScript player, StateMachine sm) : base(player, sm)
    {
    }
    public override void Enter()
    {
        base.Enter();
        pms.anim.Play("Male_Walk");
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

        pms.CheckForRun();
        pms.CheckForIdle();
        pms.CheckForAttack();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}

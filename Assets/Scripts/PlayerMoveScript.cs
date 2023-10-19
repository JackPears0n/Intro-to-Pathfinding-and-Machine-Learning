using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMoveScript : MonoBehaviour
{
    public GameObject[] targets = { };
    public int destPoint;

    public NavMeshAgent agent;

    public Animator anim;

    //Variables for player states
    public Idle idleS;
    public Walking walkingS;
    public Running runningS;
    public Attacking attackingS;

    public StateMachine sm;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        sm = gameObject.AddComponent<StateMachine>();
        anim = GetComponent<Animator>();

        // add new states here
        idleS = new Idle(this, sm);
        walkingS = new Walking(this, sm);
        runningS = new Running(this, sm);
        attackingS = new Attacking(this, sm);


        // initialise the statemachine with the default state
        sm.Init(idleS);
    }

    // Update is called once per frame
    void Update()
    {
        sm.CurrentState.HandleInput();
        sm.CurrentState.LogicUpdate();
        print(sm.CurrentState);
    }

    void FixedUpdate()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5F)
        {
            sm.ChangeState(attackingS);
            GoToTarget();
        }
    }

    public void GoToTarget()
    {
        if (targets.Length == 0)
        {
            print("No targets");
            return;
        }

        agent.destination = targets[destPoint].transform.position;
        destPoint = (destPoint + 1) % targets.Length;
    }

    public void CheckForIdle()
    {
        if (agent.velocity.magnitude < 0.15F)
        {
            sm.ChangeState(idleS);
        }
    }

    public void CheckForWalk()
    {
        if (agent.velocity.magnitude > 0 && agent.velocity.magnitude < 1)
        {
            sm.ChangeState(walkingS);
        }
    }

    public void CheckForRun()
    {
        if (agent.velocity.magnitude > 1)
        {
            sm.ChangeState(runningS);
        }
    }

    public void CheckForAttack()
    {
        if (agent.remainingDistance < 0.5F)
        {
            sm.ChangeState(attackingS);
        }
    }
}

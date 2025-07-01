using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateManager : MonoBehaviour
{
    EnemyBaseState currentState;
    public EnemyRoamState RoamState = new EnemyRoamState();
    public EnemyChaseState ChaseState = new EnemyChaseState();

    // Start is called before the first frame update
    void Start()
    {
        currentState = RoamState;
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void ChangeState(EnemyBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}

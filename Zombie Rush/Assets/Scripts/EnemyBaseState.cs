using UnityEngine;

public abstract class EnemyBaseState
{
    public abstract void EnterState(EnemyStateManager enemy);
    public abstract void UpdateState(EnemyStateManager enemy);
    public abstract void OnCollisionEnter(EnemyStateManager enemy);

}

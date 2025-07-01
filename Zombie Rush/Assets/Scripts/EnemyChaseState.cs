using UnityEngine;

public class EnemyChaseState : EnemyBaseState
{
    GameObject player;
    public override void EnterState(EnemyStateManager enemy)
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public override void UpdateState(EnemyStateManager enemy)
    {
        if (Vector3.Distance(enemy.transform.position, player.transform.position) >= 8)
        {
            enemy.ChangeState(enemy.RoamState);
        }
    }
    public override void OnCollisionEnter(EnemyStateManager enemy)
    {

    }
}

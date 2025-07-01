using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class EnemyRoamState : EnemyBaseState
{
    GameObject player;
    private EnemyMovement em;
    public override void EnterState(EnemyStateManager enemy)
    {
        player = GameObject.FindGameObjectWithTag("Player");
        em = enemy.GetComponent<EnemyMovement>();
        em.Roam();
    }
    public override void UpdateState(EnemyStateManager enemy)
    {
        if (Vector3.Distance(enemy.transform.position, player.transform.position) < 8)
        {
            enemy.ChangeState(enemy.ChaseState);
        }

        if (Vector3.Distance(enemy.transform.position, em.currentWaypoint.transform.position) < 1)
        {
            em.Roam();
        }
    }
    public override void OnCollisionEnter(EnemyStateManager enemy)
    {

    }
}

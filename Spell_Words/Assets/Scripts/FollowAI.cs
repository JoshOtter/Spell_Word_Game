using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowAI : MonoBehaviour
{
    public float patrolTime = 10.0f;
    public float aggroRange = 10.0f;
    public Transform[] waypoints;

    int index;
    public float speed, agentSpeed;
    private Transform player;

    private Animator anim;
    private NavMeshAgent agent;

    private void Awake()
    {
        //anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        if(agent != null)
        {
            agentSpeed = agent.speed;
        }

        player = GameObject.FindGameObjectWithTag("Player").transform;
        index = Random.Range(0, waypoints.Length);

        InvokeRepeating("Tick", 0, 5f);

        if(waypoints.Length > 0)
        {
            InvokeRepeating("Patrol", 0, patrolTime);
        }
    }

    void Patrol()
    {
        index = Random.Range(0, waypoints.Length);//index == waypoints.Length - 1 ? 0 : index + 1;
    }

    void Tick()
    {
        agent.destination = waypoints[index].position;

        if(player != null && Vector3.Distance(transform.position, player.position) < aggroRange)
        {
            agent.destination = player.position;
        }
    }

    //GameObject tower = GameObject.FindGameObjectWithTag("Tower");
    //public Transform target;
    //public Transform altTarget1;
    //public Transform altTarget2;
    //public Transform altTarget3;
    //public Transform altTarget4;
    //public Transform myTransform;
    //public float speed = 3;

    //void Update()
    //{
    //    SwitchTarget();
    //    transform.LookAt(target);
    //    transform.Translate(Vector3.forward * speed * Time.deltaTime);
    //}

    //void SwitchTarget()
    //{

    //    if (target != null)
    //    {
    //        target = altTarget1;
    //    }
    //}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyAI : MonoBehaviour
{

    public GameObject[] navPoint;

    public NavMeshAgent agent;

    public int currentPoint;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentPoint = 0;
        agent.destination = navPoint[currentPoint].transform.position; // destination of the ai is the position of the points that are placed on the map. 
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(this.transform.position,navPoint[currentPoint].transform.position) <= 2f)
        {
            iterate();
        }
        
    }

    void iterate()
    {
        if (currentPoint < navPoint.Length - 1) //if ai is not on last point then it will move on to the next point.
        {
            currentPoint++;

        }
        else
        {
            currentPoint = 0; // once ai has reached the last point, it will go back to the 1st point in the list.
        }
        agent.destination = navPoint[currentPoint].transform.position;
    }
}

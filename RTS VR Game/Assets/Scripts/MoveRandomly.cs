using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveRandomly : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    public GameObject Model;
    NavMeshAgent modelAgent;
    NavMeshPath path;
    public float timerForNewPath = 4;
    bool inCoRoutine = false;
    Vector3 target;
    bool validPath;

    // Start is called before the first frame update
    void Start()
    {
        modelAgent = Model.GetComponent<NavMeshAgent>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = 100.0f;
        modelAgent.speed = 100.0f;
        path = new NavMeshPath();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inCoRoutine)
        {
            StartCoroutine(doSomething());
        }
    }

    Vector3 getNewRandomPosition()
    {
        float x = Random.Range(-1000, 1000);
        float z = Random.Range(-1000, 1000);

        Vector3 pos = new Vector3(x, 0, z);

        return pos;
    }

    void GetNewPath()
    {
        target = getNewRandomPosition();
        navMeshAgent.SetDestination(target);
        modelAgent.SetDestination(target);
    }

    IEnumerator doSomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(timerForNewPath);
        GetNewPath();
        validPath = navMeshAgent.CalculatePath(target, path);
        if (!validPath) Debug.Log("Found an invalid path");

        while (!validPath)
        {
            yield return new WaitForSeconds(0.01f); //prevents crash
            GetNewPath();
            validPath = navMeshAgent.CalculatePath(target, path);
        }
        inCoRoutine = false;
    }
}

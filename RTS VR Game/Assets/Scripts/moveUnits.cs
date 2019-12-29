using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moveUnits : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    NavMeshPath path;
    public float timerForNewPath;
    bool inCoRoutine = false;
    Vector3 target;
    bool validPath;


    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
    }

    // Update is called once per frame
    void Update()
    {
        if (!inCoRoutine)
        {
            if (Input.GetMouseButtonDown(1))
            {
                StartCoroutine(doSomething());
            }
            
        }

        //GameObject gameManager = GameObject.Find("Player");
        //SelectUnits unitList = gameManager.GetComponent<SelectUnits>();
        //List<GameObject> selectedUnits = unitList._selectedUnits;

    }

    Vector3 getNewRandomPosition()
    {
        float x = Input.mousePosition.x;
        float z = Input.mousePosition.z;

        Vector3 pos = new Vector3(x, 0, z);

        return pos;
    }

    void GetNewPath()
    {
        target = getNewRandomPosition();
        navMeshAgent.SetDestination(target);
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

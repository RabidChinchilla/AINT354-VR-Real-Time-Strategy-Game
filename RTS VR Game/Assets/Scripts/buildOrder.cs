using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildOrder : MonoBehaviour
{
    
    int buildNum;
    public GameObject spawnPoint;
    public GameObject humvee;
    public GameObject tank;
    public GameObject vulcan;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BuildOrder());
    }

    // Update is called once per frame

    IEnumerator BuildOrder()
    {
        buildNum = Random.Range(1, 2);
        if(buildNum == 1)
        {
            Build(humvee);
        }
        //if (buildNum == 2)
        //{
        //    Build(tank);
        //}
        //if (buildNum == 3)
        //{
        //    Build(vulcan);
        //}
        yield return new WaitForSecondsRealtime(15);
        StartCoroutine(BuildOrder());
    }
    void Build(GameObject unit)
    {
        Instantiate(unit, spawnPoint.transform.position,spawnPoint.transform.rotation);
    }
    //void Completed()
    //{
    //    buildList.
    //}
}

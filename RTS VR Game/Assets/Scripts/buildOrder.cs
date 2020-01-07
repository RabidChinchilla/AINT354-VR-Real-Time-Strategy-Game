using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildOrder : MonoBehaviour
{
    List<GameObject> buildList;
    bool buildFree;
    GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

        GameObject newUnit = buildList[1];
        unitAttributes buildInfo = newUnit.GetComponent<unitAttributes>();
        float buildTime = buildInfo.unitBuildTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Build()
    {
        Instantiate(buildList[1], spawnPoint.transform.position,spawnPoint.transform.rotation);
    }
    //void Completed()
    //{
    //    buildList.
    //}
}

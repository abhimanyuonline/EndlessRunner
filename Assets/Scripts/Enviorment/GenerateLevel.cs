using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{

    public GameObject[] runwaySections;
    public int zPos= 56;
    public bool createRunwaySection = false;
    public int secNum;

    // Update is called once per frame
    void Update()
    {
        if (createRunwaySection)
        return;
        createRunwaySection = true;
        StartCoroutine(GenrateRunway());
    }
    IEnumerator GenrateRunway(){
        secNum = UnityEngine.Random.Range(0,3);
        Instantiate(runwaySections[secNum],new Vector3(0,0,zPos),Quaternion.identity);
        zPos += 56;
        yield return new WaitForSeconds(2);
        createRunwaySection = false;
    }
}

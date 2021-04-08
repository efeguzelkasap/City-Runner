using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlotSpawner : MonoBehaviour
{

    private int initAmount = 2;
    private float plotSize = 51f;
    private float xPosLeft = -2.8f;
    private float xPosRight = 19.5f;
    private float lastZPos = -15f;

    public List<GameObject> plots;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < initAmount; i++)
        {
            SpawnPlot();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlot()
    {
        //GameObject movedPlots = plots[0];
        //plots.Remove(movedPlots);

        //GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        //GameObject plotRight = plots[Random.Range(0, plots.Count)];

        float zPos = lastZPos + plotSize;

        //Instantiate(plotLeft, new Vector3(xPosLeft, 13f, zPos), plotLeft.transform.rotation);
        //Instantiate(plotRight, new Vector3(xPosRight, 13f, zPos - 10), new Quaternion(0, 180, 0, 0));

        //lastZPos += plotSize;

        //plots.Add(movedPlots);

        GameObject movedPlot = plots[0];
        plots.Remove(movedPlot);
        float newZ = plots[plots.Count - 1].transform.position.z + zPos;
        movedPlot.transform.position = new Vector3(0, 0, newZ);
        plots.Add(movedPlot);

    }

}

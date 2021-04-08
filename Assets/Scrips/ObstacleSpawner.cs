using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public List<GameObject> obstacles;
    [SerializeField] private Transform player;
    [SerializeField] private float offset = 80f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        //SpawnObstacles();
        if (obstacles != null && obstacles.Count > 0)
        {
            obstacles = obstacles.OrderBy(obstacles => obstacles.transform.position.z).ToList();
        }
    }

    

    public void SpawnObstacles()
    {
        //GameObject Ob = obstacles[Random.Range(0, obstacles.Count)];

        //float randomNumber = Random.Range(0, 3);



        //if (randomNumber == 0)
        //{
        //    Instantiate(Ob, new Vector3(6f, 0f, player.position.z + 40), Ob.transform.rotation);
        //}
        //else if (randomNumber == 1)
        //{
        //    Instantiate(Ob, new Vector3(11f, 0f, player.position.z + 40), Ob.transform.rotation);
        //}
        //else
        //{
        //    Instantiate(Ob, new Vector3(6f, 0f, player.position.z + 20), Ob.transform.rotation);
        //    Instantiate(Ob, new Vector3(11f, 0f, player.position.z + 10), Ob.transform.rotation);
        //}


        GameObject movedObstacle = obstacles[0];
        obstacles.Remove(movedObstacle);
        //float newZ = obstacles[obstacles.Count - 1].transform.position.z + offset;
        float newZ = player.position.z + offset;
        movedObstacle.transform.position = new Vector3(6, 0, newZ);
        obstacles.Add(movedObstacle);


    }

}

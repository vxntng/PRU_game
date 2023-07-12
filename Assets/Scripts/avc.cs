using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avc : MonoBehaviour
{
    public GameObject floor;
    public GameObject floorpre;
    public GameObject trannha;
    public GameObject trannhapre;
    public GameObject contho;


    // Start is called before the first frame update

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;

    public GameObject obstaclePrefab;

    public float minObstacleY = -1f;
    public float maxObstacleY = 1f;

    public float minObstacleSpacing = 5f;
    public float maxObstacleSpacing = 9f;

    public float minObstacleScaleY = 2f;
    public float maxObstacleScaleY = 7f;
    void Start()
    {
        obstacle1 = GenerateObstacle(contho.transform.position.x + 10);
        obstacle2 = GenerateObstacle(obstacle1.transform.position.x);
        obstacle3 = GenerateObstacle(obstacle2.transform.position.x);
        obstacle4 = GenerateObstacle(obstacle3.transform.position.x);
    }

    GameObject GenerateObstacle(float referenceX)
    {
        GameObject obstacle = GameObject.Instantiate(obstaclePrefab);
        SetTransform(obstacle, referenceX);
        return obstacle;
    }
    void SetTransform(GameObject obstacle, float referenceX)
    {
        float obstacleScaleY = Random.Range(minObstacleScaleY, maxObstacleY);
        float obstacleSpacing = Random.Range(minObstacleSpacing, maxObstacleSpacing);

        //obstacle.transform.position = new Vector3(referenceX + Random.Range(minObstacleSpacing, maxObstacleSpacing), Random.Range(minObstacleY, maxObstacleY), 0);
        //obstacle.transform.localScale = new Vector3(obstacle.transform.localScale.x, Random.Range(minObstacleScaleY, maxObstacleY), obstacle.transform.localScale.z);
        obstacle.transform.position = new Vector3(referenceX + obstacleSpacing, Random.Range(minObstacleY, maxObstacleY), 0);
        obstacle.transform.localScale = new Vector3(obstacle.transform.localScale.x, obstacleScaleY, obstacle.transform.localScale.z);
    }
        //void SetTransform(GameObject obstacle, float referenceX)
        //{
        //    obstacle.transform.position = new Vector3(referenceX + Random.Range(minObstacleSpacing, maxObstacleSpacing), Random.Range(minObstacleY, maxObstacleY), 0);
        //    obstacle.transform.localScale = new Vector3(obstacle.transform.localScale.x, Random.Range(minObstacleScaleY, maxObstacleY), obstacle.transform.localScale.z);
        //}


    // Update is called once per frame
    void Update()
    {
        if (contho.transform.position.x > floor.transform.position.x)
        {
            var tempCeiling = trannhapre;
            var tempFloor = floorpre;
            trannhapre = trannha;
            floorpre = floor;
            tempCeiling.transform.position += new Vector3(50, 0, 0);
            tempFloor.transform.position += new Vector3(50, 0, 0);
            trannha = tempCeiling;
            floor = tempFloor;


        }
        if (contho.transform.position.x > obstacle2.transform.position.x)
        {
            var tempObstacle = obstacle1;
            obstacle1 = obstacle2;
            obstacle2 = obstacle3;
            obstacle3 = obstacle4;

            SetTransform(tempObstacle, obstacle3.transform.position.x);
            obstacle4 = tempObstacle;

        }
    }
}

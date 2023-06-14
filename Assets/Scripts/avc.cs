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
    void Start()
    {

    }

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
    }
}

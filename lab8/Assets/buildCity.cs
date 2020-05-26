using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class buildCity : MonoBehaviour
{
    public GameObject[] buildings;
    public int mapWidth = 20;
    public int mapHeight = 20;
    public int buildingFootprint = 3;


    // Start is called before the first frame update
    void Start()
    {
        float seed = Random.Range(0, 100);
        for(int h = 0; h < mapHeight; h++)
        {
            for(int w = 0; w < mapWidth; w++)
            {

                int result = (int) (Mathf.PerlinNoise(w / 10.0f + seed, h / 10.0f + seed) * 10);
                UnityEngine.Vector3 pos = new UnityEngine.Vector3(w * buildingFootprint, 0, h * buildingFootprint);
                
                if (result < 4)
                {
                    Instantiate(buildings[0], pos, UnityEngine.Quaternion.identity);
                } else if (result < 5)
                {
                    Instantiate(buildings[1], pos, UnityEngine.Quaternion.identity);
                }
                else if (result < 7)
                {
                    Instantiate(buildings[2], pos, UnityEngine.Quaternion.identity);
                }
                else if (result < 8)
                {
                    Instantiate(buildings[3], pos, UnityEngine.Quaternion.identity);
                }
                else if (result < 10)
                {
                    Instantiate(buildings[4], pos, UnityEngine.Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

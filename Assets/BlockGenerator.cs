using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{

    public GameObject terrainCube;
    float Perlin1, Perlin2;
    // Start is called before the first frame update
    void Start()
    {
        for (float px = 0; px < 300; px++)
        {
            for (float py = 0; py < 300; py++)
            {
                //Perlin Noise expects floating co-ordinates
                Perlin1 = Mathf.PerlinNoise(px / 30, 76);
                Perlin2 = Mathf.PerlinNoise(py / 30, 22);
                Debug.Log(Perlin1 + " " + Perlin2);
                Instantiate(terrainCube, new Vector3(py - 50, Perlin1 * 70 * Perlin2, px - 50), Quaternion.identity);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

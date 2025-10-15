using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

public class Scanner : MonoBehaviour
{
    public GameObject scannerPrefab;
    public float duration = 50;
    public float size = 500;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SpawnTerrainScanner();
        }
    }

    //void SpawnTerrainScanner()
    // {
    // GameObject terrainScanner = GameObject.Instantiate(scannerPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
    //ParticleSystem terrainscannerPS = terrainScanner.transform.GetChild(0).GetComponent<ParticleSystem>();
    //if (terrainScanner != null)
}

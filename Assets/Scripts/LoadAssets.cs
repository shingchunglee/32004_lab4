using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;

    // Start is called before the first frame update
    void Start()
    {
        // Set framerate to 60
        Application.targetFrameRate = 60;

        // Instantiate red object at position (2,0,0)
        Instantiate(redObj, new Vector3(2.0f, 0, 0), Quaternion.identity);
        // Instantiate blue object at position (-2,0,0)
        Instantiate(blueObj, new Vector3(-2.0f, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

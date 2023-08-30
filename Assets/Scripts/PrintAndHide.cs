using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide: MonoBehaviour
{
    private int i;
    private int randomNumber;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randomNumber = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Blue" && i == randomNumber)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        Debug.Log($"{gameObject.name}:{++i}");
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
    }
}

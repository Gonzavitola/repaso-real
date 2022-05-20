using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBehavior : MonoBehaviour
{
    public float speed;
    public bool toRight;
    public GameObject baseIzq;
    public GameObject baseDer;
    public GameObject prefab1;
    public GameObject prefab2;
    int yOffset;
    // Start is called before the first frame update
    void Start()
    {

        toRight = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
            transform.position += new Vector3(speed, 0, 0);

        }
        else
        {
            transform.position -= new Vector3(speed, 0, 0);

        }
        if (transform.position.x > baseDer.transform.position.x -2)
        {
            toRight = false;
            GameObject clon;
            clon = Instantiate(prefab1);
            clon.transform.position = baseDer.transform.position + new Vector3(0, yOffset, 0);
        }
        if (transform.position.x < baseIzq.transform.position.x + 2)
        {
            toRight = true;
            GameObject clon;
            clon = Instantiate(prefab2);
            clon.transform.position = baseIzq.transform.position + new Vector3(0, yOffset+yOffset, 0);

        }
    }
    }

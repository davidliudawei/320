using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    string str = "5";
    void Update()
    {
        for (int i = 0; i < 100; i++)
        {
            str += i.ToString();
        }

        transform.Rotate(Vector3.up, 10,Space.World);
    }
}

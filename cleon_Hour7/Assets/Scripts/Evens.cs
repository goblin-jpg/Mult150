using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int startRange = 22;
        int endRange = 100;

        for (int i = startRange; i <= endRange; i++)
        
            if (i % 2 == 0)
        
        print(i);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

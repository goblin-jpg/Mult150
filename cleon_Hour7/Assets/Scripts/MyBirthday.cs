using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 1; i <= 12; i++) {
    if (i == 2) {

    print("It's my birthday!");
        }
    else  { print(i);
        }
    
            }
            for (int day = 1; day <= 29; day++){
                if (day == 22) {
                    print("It's my birthday!");
                }
                else {
                    print(day);
                }
            }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
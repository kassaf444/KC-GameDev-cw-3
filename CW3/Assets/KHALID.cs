using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KHALID : MonoBehaviour
{ string heroname = "khalid";
        int heropower = 27;
        string villainname = "ali";
    int villpower = 25;
    float playerspeed = 1.2f;
    float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villainpower)
        {
            print ("the hero is bigeer than the villain")
        }
        else if (villainpower > heropower)
        {
            print("the villain is bigger than hero")
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setspeed(float speed)
    {
        print(playerspeed);
        playerspeed = 2.5f;
        print(playerspeed)
        


    }
}

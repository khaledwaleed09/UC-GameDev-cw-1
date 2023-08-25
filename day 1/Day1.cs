using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string heroName = "Batman";
        int age = 38;
        bool isHero = true;
        float speed = 15.5f;


        string villainName = "Joker";
        int age1 = 25;
        bool is_Hero = false;
        float speed1 = 20.5f;

        print("My Name is " + heroName + " And my age is " + age);
        print("my name is " + villainName + " and my age is " + age1);

        int x = 38 - 25;
        print(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

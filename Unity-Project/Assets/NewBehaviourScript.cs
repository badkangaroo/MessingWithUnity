using System.Collections;
using System.Collections.Generic;

using TMPro.EditorUtilities;

using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int Waffles;

    void Start()
    {
        //int pancakes = BobsPancakes();
        //Debug.Log("Pancakes: " + pancakes);
        
        for(int i = 0; i < 5; i++)
        {
            BobsBreakfast();
        }
        Debug.Log("Waffles:" + Waffles);

        BobsInAndOut(ref Waffles);
        Debug.Log("Waffles:" + Waffles);

        BobsInAndOutTwo(out Waffles);
        Debug.Log("Waffles:" + Waffles);

        Combine();
        Combine(3);
        Combine(5f);
        Combine(3, 5);
        
        //Debug.Log("Steaks?" + BobsSteakHouse());
    }
    void Combine(int a, int b)
    {
        Debug.Log(a + b);
    }

    void Combine(float b)
    {
        int a = 1;
        Debug.Log(a + b);
    }
    void Combine(int a)
    {
        int b = 2;
        Debug.Log(a + b);
    }
    void Combine()
    {
        int a = 1;
        int b = 2;
        Debug.Log(a + b);
    }

    void BobsInAndOut(ref int Food)
    {
        Food--;
    }

    void BobsInAndOutTwo(out int Food)
    {
        Food = BobsPancakes();
    }

    void BobsBreakfast()
    {
        for (int i = 0; i < 10; i++)
        {
            Waffles++;
        }
    }

    int BobsPancakes()
    {
        int Pancakes = 3;
        return Pancakes;
    }

    int BobsSteakHouse()
    {
        return 10;
    }

    void BobsHouse()
    {
        int j = 0;

        for(int i = 0; i < 10; i++)
        {
            j++;
        }

        for (int i = 0; i < 10; i++)
        {
            j++;
        }

        for (int i = 0; i < 10; i++)
        {
            j++;
            Debug.Log(j);
        }
    }


    // Update is called once per frame
    void Update()
    {
    }
}

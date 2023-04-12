using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] int manaJouable;
    [SerializeField] int compteurTour;
    [SerializeField] bool jouable;

    void Start()
    {
        manaJouable = 2;
    }
    void Update()
    {
        if(jouable == true)
        {
            Tour();
        }
    }

    void Tour()
    {
        ///
    }
}

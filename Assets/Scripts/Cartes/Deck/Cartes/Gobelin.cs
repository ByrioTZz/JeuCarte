using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gobelin : CartesMain
{
    void Start()
    {
        Stats();
    }

    void Stats()
    {
        mana = 1;
        vie = 4;
        defense = 0;
        attaque = 2;
        maxVie = 4;
    }
}

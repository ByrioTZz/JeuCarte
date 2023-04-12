using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarteMain : MonoBehaviour
{
    int prix;
    int hp;
    protected int maxhp;

    static int attaque;

    virtual protected void effect()
    {

    }

    public void playcard(int n)
    {
        if(n > prix)
        {
            effect();
        }
    }

}
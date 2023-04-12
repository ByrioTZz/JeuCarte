using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailsPersonnages : MonoBehaviour
{
    [SerializeField] protected int attaque, defense, vie;
    [SerializeField] protected string effets;

    /*
    public void Stats(int attaque,int defense,int vie)
    {
        this.attaque = attaque;
        this.defense = defense;
        this.vie = vie;
    }

    public void Effets(string effets)
    {
        this.effets = effets;
    }
    */

    public string Affichage()
    {
        return "Stats att : " + attaque + "/nStats def : " + defense + "/nStats vie : " + vie;
    }
}
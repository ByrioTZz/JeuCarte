using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourManager : MonoBehaviour
{
    public int tourCompteur;
    public bool tourJoueur;
    ManaManager manaManager;


    void Start()
    {
        tourCompteur= 0;
        ChoixStart();
    }

    void Update()
    {
        Bool();
    }

    void ChoixStart()
    {
        ///booléen permettant le choix du start de la part du joueur///
    }

    void Bool()
    {
        if(tourJoueur == true)
        {
            manaManager.manaJoueur = manaManager.maxManaJoueur;     ///set le mana du joueur a son maxMana au debut du tour
        }
        else if(tourJoueur == false)
        {
            manaManager.manaJoueur = manaManager.minManaJoueur;     ///set le mana du joueur a son min ( =0)
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leader1 : LeaderMain
{
    [SerializeField] bool activeSkill;

    void Start()
    {
        Stats();
    }
    void Update()
    {
        ActiveSkill();
    }

    void Effets()
    {
        /// sert a gerer les effets de la carte///
    }

    void Stats()
    {
        mana = 20;
        vie = 30;
        attaque = 9;

        effets = "inflige " +attaque +" de dégats pour " +mana+" de mana";
    }

    void ActiveSkill()
    {
        ///gestion de l'actif du leader (depend du mana)///
    }
}

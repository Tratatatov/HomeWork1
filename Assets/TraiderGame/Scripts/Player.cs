using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum Characters
    {
        Geralt,
        Dragonborn,
        Cat
    }
    public Characters character;
    public void SetPersonGeralt()=> character = Characters.Geralt;
    public void SetPersonDragonBorn()=> character = Characters.Dragonborn;
    public void SetPersonCat()=> character = Characters.Cat;
    private void Awake()=> character = Characters.Cat;
        

        
}

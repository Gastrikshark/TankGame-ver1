using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private int spelerBeurt = 1;
    GameObject Speler1;
    GameObject Speler2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] spelers = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject g in spelers)
        {
            if (g.GetComponent<TankController>().spelerNummer == 1)
            {
                Speler1 = g;
                
            }
            else if (g.GetComponent<TankController>().spelerNummer == 2)
            {
                Speler2 = g;
            }
        }
        // de speler die aan de beurt is actief maken 
        Invoke("init", 0.1f);
       
    }    

    void init()
    {
        if (spelerBeurt == 1)
        {            
            // Maak speler 1 actief
            Speler1.GetComponent<TankController>().ZetActief(true);
            Speler2.GetComponent<TankController>().ZetActief(false);
        }
        else if (spelerBeurt == 2)
        {
            // maak speler 2 actief
            Speler1.GetComponent<TankController>().ZetActief(false);
            Speler2.GetComponent<TankController>().ZetActief(true);
        }
    }

    public void WisselBeurt()
    {
        if (spelerBeurt == 1)
        {
            spelerBeurt = 2;
            Speler1.GetComponent<TankController>().ZetActief(false);
            Speler2.GetComponent<TankController>().allowedToShoot = true;
            Speler2.GetComponent<TankController>().ZetActief(true);
        }
        else if (spelerBeurt == 2)
        {
            spelerBeurt = 1;
            Speler1.GetComponent<TankController>().ZetActief(true);
            Speler1.GetComponent<TankController>().allowedToShoot = true;
            Speler2.GetComponent<TankController>().ZetActief(false);
        }
    }

    //zet een players still als als er een player niet aan de beurt is
    public void FreezePlayers()
    {
        Speler1.GetComponent<TankController>().magBewegen = false;
        Speler1.GetComponent<TankController>().magBewegen = false;
    }
    //laat een player weer begwegen als die weer aan de beurt is 
    public void UnFreezePlayers()
    {
        Speler1.GetComponent<TankController>().magBewegen = true;
        Speler2.GetComponent<TankController>().magBewegen = true;
    }



}

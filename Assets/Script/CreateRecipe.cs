using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRecipe : MonoBehaviour
{
    public int startNumber = 10;
    public float inc = 1.2f;
    public int ressourcesNumber = 12;
    int firstRessource = 0;
    int secondRessource = 0;
    int firstRessourceId = 0;
    int secondRessourceId = 0;

    // Start is called before the first frame update
    void Start()
    {
        // generateRecipe();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateRecipe()
    {
        firstRessource = Random.Range(1, startNumber);
        secondRessource = startNumber - secondRessource;
        firstRessourceId = Random.Range(1, ressourcesNumber); 
        do {
            secondRessourceId = Random.Range(1, ressourcesNumber);
        } while (firstRessourceId == secondRessourceId);
    }

    public void updateNumber()
    {
        startNumber = (int)System.Math.Round(inc * startNumber);
    }

    public int getFristId()
    {
        return (firstRessourceId);
    }

    public int getSecondId()
    {
        return (secondRessourceId);
    }

    public int getFrist()
    {
        return (firstRessource);
    }

    public int getSecond()
    {
        return (secondRessource);
    }
}

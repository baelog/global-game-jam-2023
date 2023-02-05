using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintRessources : MonoBehaviour
{
    WorkerInventory inventory;
    CreateRecipe recipe;
    public Text firstRessourceText;
    public Text secondRessourceText;
    
    // Start is called before the first frame update
    void Start()
    {
        inventory = GetComponent<WorkerInventory>();
        recipe = GetComponent<CreateRecipe>();
        recipe.generateRecipe();
    }

    // Update is called once per frame
    void Update()
    {
        int[] ressourcesList = inventory.getInventory();
        firstRessourceText.text = ressourcesList[recipe.getFristId()] + "/"  + recipe.getFrist();
        secondRessourceText.text = ressourcesList[recipe.getSecondId()] + "/" + recipe.getSecond();
    }
}

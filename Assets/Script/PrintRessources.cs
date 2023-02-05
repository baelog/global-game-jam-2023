using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.UI;

public class PrintRessources : MonoBehaviour
{
    WorkerInventory inventory;
    CreateRecipe recipe;
    public Text firstRessourceText;
    public Text secondRessourceText;
    public ReadOnlyCollection<string> names { get; } = new ReadOnlyCollection<string>(
    new string[] {
        "cranberry",
        "blue berry",
        "goose berry",
        "sumac",
        "lavender",
        "rosemary",
        "almandine",
        "amber",
        "adamite",
        "oyster",
        "chanterelle",
        "indigo mushroom"
    });

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
        firstRessourceText.text = names[recipe.getFristId()] + ": " + ressourcesList[recipe.getFristId()] + "/"  + recipe.getFrist();
        secondRessourceText.text = names[recipe.getSecondId()] + ": " + ressourcesList[recipe.getSecondId()] + "/" + recipe.getSecond();
        if (ressourcesList[recipe.getFristId()] >= recipe.getFrist() && ressourcesList[recipe.getSecondId()] >=recipe.getSecond()) {
            recipe.updateNumber();
            recipe.generateRecipe();
        }
    }
}

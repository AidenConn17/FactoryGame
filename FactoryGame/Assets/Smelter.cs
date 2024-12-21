using UnityEngine;

public class Smelter : MonoBehaviour
{
    public Recipe recipe = new Recipe(1);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        recipe = new Iron(4);
        SetRecipe(new Copper(3));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetRecipe(Recipe newRecipe)
    {
        recipe = newRecipe;
    }
}

public class Recipe
{
    public int requiredMaterials {get; private set; }

    public Recipe(int requiredMaterials)
    {
        this.requiredMaterials = requiredMaterials;
    }
}

public class Iron : Recipe
{
    public int requiredMaterials {get; private set; }

    public Iron(int requiredMaterials)
    {
        this.requiredMaterials = requiredMaterials;
    }
}

public class Copper : Recipe
{
    public int requiredMaterials {get; private set; }

    public Copper(int requiredMaterials)
    {
        this.requiredMaterials = requiredMaterials;
    }
}

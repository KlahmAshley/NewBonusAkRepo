using UnityEngine;

public class AppleFactory : Factory
{   public override IFruit SpawnFruit(GameObject fruitPrefab)
    {
        return new Apple();
    }

}

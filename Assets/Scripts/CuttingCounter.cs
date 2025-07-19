using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{

    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no Kitchen Object here
            if (player.HasKitchenObject())
            {
                // The player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                // The player is holding nothing
            }
        }
        else
        {
            //There is a Kitchen Object here
            if (player.HasKitchenObject())
            {
                // The player is carrying something
            }
            else
            {
                // The player is holding nothing
                GetKitchenObject().SetKitchenObjectParent(player);
            }

        }
    }

    public override void InteractAlternate(Player player)
    {
        if (HasKitchenObject())
        {
            // There is a Kitchen Object in here
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }
    }
}

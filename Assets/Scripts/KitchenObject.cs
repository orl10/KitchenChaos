using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO KitchenObjectSO;

    public KitchenObjectSO GetKitchenObjectSO()
    {
        return KitchenObjectSO;
    }
}

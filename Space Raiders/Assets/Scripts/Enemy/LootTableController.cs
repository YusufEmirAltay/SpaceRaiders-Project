using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootTableController : MonoBehaviour
{
        
    [field: SerializeField]
    public List<PowerUpController> PowerUps { get; private set; }
    [field: SerializeField]
    public float DropProbability { get; private set; }

    public void CheckDrop(DestructableController destructable)
    {
        float chance = Random.Range(0f, 1f);

        if (chance > 0.5f) return; 

        if (PowerUps.Count > 0)
        {
        int ix = Random.Range(0, PowerUps.Count);
        PowerUpController powerUp = PowerUps[ix];
        Instantiate(powerUp, destructable.transform.position, Quaternion.identity);
        }
    }
}

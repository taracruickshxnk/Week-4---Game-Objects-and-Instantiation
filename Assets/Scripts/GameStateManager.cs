using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameStateManager : MonoBehaviour
{
    public GameObject prefab;
    public int howMany;

    void Start() {
        GameObject tmpAsteroid;
        AsteroidMove am;

        for (int i = 0; i < howMany; i++)
        {
            tmpAsteroid = Instantiate(
                prefab,
                new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0),
                Quaternion.identity
             );

            am = tmpAsteroid.GetComponent<AsteroidMove>();

            am.mx = Random.Range(-8, 8);
            am.my = Random.Range(-8, 8);
            am.rotz = Random.Range(-3, 3);
        }
    }

    void Update() {

    }
}


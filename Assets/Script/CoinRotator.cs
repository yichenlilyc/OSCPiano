using UnityEngine;
using System.Collections;

public class CoinRotator : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 0) * Time.deltaTime*5);
    }
}

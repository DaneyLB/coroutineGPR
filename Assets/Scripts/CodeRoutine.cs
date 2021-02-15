using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeRoutine : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(Print());

    }
    IEnumerator Print()
    {

        Debug.Log("Ik start nu de coroutine");
        yield return new WaitForSeconds(0.5f);
        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            Debug.Log("coroutine update");
        }
        yield return new WaitForSeconds(0.5f);
        Debug.Log("coroutine einde");

    }
}

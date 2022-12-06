using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour
{
    public List<Transform> points;

    private const float timeMin = 0.0f;
    private const float timeMax = 3.0f;
    private float time = timeMin;



    int posIndex;

    //float t = 0f;


    private void Update()
    {

        float t = time / timeMax;
        time += Time.smoothDeltaTime;


        Vector3 src = points[posIndex].position;
        Vector3 dst = points[(posIndex + 1) % points.Count].position;


        transform.position = Vector3.Lerp(src, dst, t);
        if (time >= timeMax)
        {
            time = timeMin;
            posIndex++;
            posIndex %= points.Count;

        }

    }
}

using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class segmentScenes : MonoBehaviour
{
    public GameObject[] segments;

    [SerializeField] int zpos = 38;
    [SerializeField] bool creatingsement = false;
    [SerializeField] int segmentnumber; 

    void Update()
    {
        if (creatingsement == false)
        {
            creatingsement = true;
             StartCoroutine(segmentgen());
        }
       
    }
    IEnumerator segmentgen()
    {
        segmentnumber = Random.Range(0, 3);
        Instantiate(segments[segmentnumber], new Vector3(-6.1f, 0.8f, zpos), quaternion.identity);
        zpos += 38;
        yield return new WaitForSeconds(3);
        creatingsement = false; ;
        
    }


}

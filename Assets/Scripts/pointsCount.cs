using UnityEngine;

public class PointsCount : MonoBehaviour
{
    public static int pointcount = 0;
    [SerializeField] GameObject poindisplay;
 
    // Update is called once per frame
    void Update()
    {
        poindisplay.GetComponent<TMPro.TMP_Text>().text = "cheese:" + pointcount;
    }
}

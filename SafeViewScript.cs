using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeViewScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float diff = Screen.height -  Screen.safeArea.height ;

        if (diff == 0) return;
        foreach (RectTransform asd in this.transform)
            asd.offsetMax = new Vector2(asd.offsetMax.x, -diff);
    }


}

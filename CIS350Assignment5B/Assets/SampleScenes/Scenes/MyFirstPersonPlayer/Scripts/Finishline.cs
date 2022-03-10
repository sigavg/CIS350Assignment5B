/* Luke Lesimple
 * Project 5B
 * Finish line script
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finishline : MonoBehaviour
{
    public Canvas finishCanvas;

    // Start is called before the first frame update
    void Start()
    {
        finishCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        finishCanvas.enabled = true;
    }

}

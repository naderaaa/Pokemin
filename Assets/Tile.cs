using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    
    public int posx;
    public int posy;
    


    // Start is called before the first frame update
    void Start()
    {
    }

    public void PosGeneration()
    {
        Vector3 pos = new((posx * 109) + 111, (posy * 109) + 100, gameObject.transform.position.z);
        gameObject.transform.position = pos;
            
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

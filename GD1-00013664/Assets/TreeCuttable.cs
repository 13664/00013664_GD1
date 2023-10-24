using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCuttable : ToolKit
{
    public virtual void Hit()
    {
        Destroy(gameObject);
    }
    
}

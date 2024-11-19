using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{ 
    public struct Position
    {
        public float X, Y, Z;

        public Position(float x, float y, float z)
        {
            this.X =x;
            this.Y = y;
            this.Z = z;
        }

        public void printPosition()
        {
            Debug.Log("Position: X="+X+" Y="+Y+" Z="+Z);
        }
    }
}    

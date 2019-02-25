using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlagCreator
{
    public class ShapeController : MonoBehaviour
    {
        public static float TransformSpeed = 1.5f;
        public bool selected = false;

        private void Update()
        {
            if (selected)
            {
                keyMovementUpdate();
            }
        }
        
        public void keyMovementUpdate()
        {
            if (Input.GetKey(KeyCode.LeftArrow)){
                transform.Translate(-(Time.deltaTime * TransformSpeed), 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow)){
                transform.Translate(Time.deltaTime * TransformSpeed, 0, 0);
            }

            if (Input.GetKey(KeyCode.UpArrow)){
                transform.Translate(0, Time.deltaTime * TransformSpeed, 0);
            }

            if (Input.GetKey(KeyCode.DownArrow)){
                transform.Translate(0, -(Time.deltaTime * TransformSpeed), 0);
            }
        }
    }
}

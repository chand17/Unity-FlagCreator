using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlagCreator
{
    [RequireComponent(typeof(Outline))]
    public class ShapeController : MonoBehaviour
    {
        public float TransformSpeed = 1.5f;
        public bool selected = false;

        private Outline outline;

        void Awake()
        {
            outline = GetComponent<Outline>();
        }

        private void Update()
        {
            if (selected)
            {
                keyMovementUpdate();
            }
        }
        
        public void Selected(bool selected)
        {
            this.selected = selected;

            //Enable and disables Outline based on if it is selected
            outline.enabled = selected;
        }

        public void keyMovementUpdate()
        {
            //Modify Speed with Shift to be faster
            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
             TransformSpeed = TransformSpeed * 2;
            if(Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift)) 
                TransformSpeed = TransformSpeed / 2;

            //Modify Speed with CTRL to be slower
            if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
             TransformSpeed = TransformSpeed / 2;
            if(Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(KeyCode.RightControl)) 
                TransformSpeed = TransformSpeed * 2;

            //Key Controls
            if (Input.GetKey(KeyCode.LeftArrow ) || Input.GetKey(KeyCode.A)){
                transform.Translate(-(Time.deltaTime * TransformSpeed), 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
                transform.Translate(Time.deltaTime * TransformSpeed, 0, 0);
            }

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
                transform.Translate(0, Time.deltaTime * TransformSpeed, 0);
            }

            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
                transform.Translate(0, -(Time.deltaTime * TransformSpeed), 0);
            }
        }
    }
}

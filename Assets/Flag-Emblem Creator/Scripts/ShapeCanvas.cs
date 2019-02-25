using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlagCreator
{
    public class ShapeCanvas : MonoBehaviour
    {
        public Rect RectSize;

        private List<ShapeController> shapes;
        private int selectedShape;

        private void Start()
        {
            RectSize = GetComponent<RectTransform>().rect;
            shapes = new List<ShapeController>();
            selectedShape = 0;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                //Cycle Shapes
                if (shapes != null)
                {
                    shapes[selectedShape].selected = false;

                    if (selectedShape + 1 < shapes.Count)
                    {
                        selectedShape++;
                    }
                    else
                    {
                        selectedShape = 0;
                    }

                    shapes[selectedShape].selected = true;
                }
            }
        }

        public void AddShape(ShapeController shape)
        {
            shapes.Add(shape);

            //TEMP
            if (shapes.Count == 1) shapes[0].selected = true;   
        }
    }
}
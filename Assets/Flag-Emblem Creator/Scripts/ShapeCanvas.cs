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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Cycle Shapes
                if (shapes != null)
                {
                    int selectShape = selectedShape;

                    if (selectShape + 1 < shapes.Count)
                    {
                        selectShape++;
                    }
                    else
                    {
                        selectShape = 0;
                    }

                    ChangeSelectedShape(selectShape);
                }
            }
        }

        public void AddShape(ShapeController shape)
        {
            shapes.Add(shape);

            ChangeSelectedShape(shapes.Count - 1);
        }

        public void ChangeSelectedShape(int selectShape)
        {
            shapes[selectedShape].Selected(false);
            shapes[selectShape].Selected(true);
            selectedShape = selectShape;
        }

        public void DeselectAll()
        {
            shapes[selectedShape].Selected(false);
        }
    }
}
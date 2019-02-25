using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlagCreator
{
    [RequireComponent(typeof(Dropdown))]
    public class ShapeSelector : MonoBehaviour
    {
        public Dropdown dropdown;

        private void Start()
        {
            dropdown = GetComponent<Dropdown>();
            SetShapes(shapes);
        }

        [SerializeField] private List<Sprite> shapes;
        private int selectedItem = 0;

        //public event Action<int> OnSelectionChange = delegate { };
        //public void ChangeSelection(int i)
        //{
        //    if(i != selectedItem) OnSelectionChange(i);
        //}

        public void SetShapes(List<Sprite> shapes)
        {
            if (shapes != null)
            {
                this.shapes = shapes;
                dropdown.AddOptions(shapes);

                //for (int i = 0; i < shapes.Count; i++)
                //{
                //    shapes[i].i = i;
                //    shapes[i].SetItemHolder(this);
                //}
            }
        }
        public Sprite GetSelectedShape()
        {
            if (shapes != null)
            {
                return shapes[dropdown.value];
            }
            else
            {
                Debug.Log("Shapes List is Empty");
                return null;
            }
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlagCreator
{
    public class AddShape : MonoBehaviour
    {
        public ShapeSelector shapeSelector;
        public ShapeCanvas canvas;
        public GameObject ShapeTemplate;

        public void AddNewShape()
        {
            if (shapeSelector != null)
            {
                createShapeController(shapeSelector.GetSelectedShape());
            }
        }

        private ShapeController createShapeController(Sprite shapeSprite)
        {
            GameObject newShape = GameObject.Instantiate(ShapeTemplate, ShapeTemplate.transform.position, canvas.transform.rotation);
            newShape.transform.SetParent(canvas.transform, false);
            newShape.SetActive(true);
            
            Image image = newShape.GetComponent<Image>();
            image.sprite = shapeSprite;

            ShapeController controller = newShape.AddComponent<ShapeController>();
            canvas.AddShape(controller);
            return controller;
        }
    }
}
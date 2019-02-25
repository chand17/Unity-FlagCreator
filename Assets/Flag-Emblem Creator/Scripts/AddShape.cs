using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlagCreator
{
    public class AddShape : MonoBehaviour
    {
        public ShapeSelector shapeSelector;
        public ShapeCanvas canvas;

        public void AddNewShape()
        {
            if (shapeSelector != null)
            {
                createShapeController(shapeSelector.GetSelectedShape());
            }
        }

        private ShapeController createShapeController(Sprite shapeSprite)
        {
            GameObject newShape = new GameObject(shapeSprite.name);
            newShape.transform.parent = canvas.transform;
            newShape.transform.position = canvas.transform.position;

            SpriteRenderer SpriteRend = newShape.AddComponent<SpriteRenderer>();
            SpriteRend.sprite = shapeSprite;
            SpriteRend.sortingOrder = 1;

            ShapeController controller = newShape.AddComponent<ShapeController>();
            canvas.AddShape(controller);
            return controller;
        }
    }
}
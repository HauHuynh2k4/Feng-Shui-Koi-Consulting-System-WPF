﻿using FengShuiKoi_BO;
using FengShuiKoi_DAO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FengShuiKoi_Repository
{
        public class ShapeRepo : IShapeRepo
        {
                public async Task<Shape> GetShapeById(string id) => await ShapeDAO.Instance.GetShapeById(id);

                public async Task<List<Shape>> GetShapes() => await ShapeDAO.Instance.GetShapes();

                public async Task<bool> AddShape(Shape shape) => await ShapeDAO.Instance.AddShape(shape);
                public async Task<List<Shape>> GetShapeByContainsShape(string shape) => await ShapeDAO.Instance.GetShapeByContainsShape(shape);
                public async Task<bool> DeleteShape(string id) => await ShapeDAO.Instance.DeleteShape(id);
                public async Task<Shape> GetShapeByImg(string img) => await ShapeDAO.Instance.GetShapeByImg(img);
                public async Task<bool> UpdateShape(Shape shape) => await ShapeDAO.Instance.UpdateShape(shape);
                public async Task<bool> UpdateShapeImg(string shapeId, string Img) => await ShapeDAO.Instance.UpdateShapeImg(shapeId, Img);
                public async Task<List<Shape>> GetShapesAndPoint() => await ShapeDAO.Instance.GetShapesAndPoint();
                public async Task<bool> UpdateShapeAndPoint(Shape _shape, List<PointOfShape> pointOfShapes) => await ShapeDAO.Instance.UpdateShapeAndPoint(_shape, pointOfShapes);
                public async Task<bool> AddShapeAndPoint(Shape _shape, List<PointOfShape> pointOfShapes) => await ShapeDAO.Instance.AddShapeAndPoint(_shape, pointOfShapes);
        }
}


using ShapeTest.Models;
using ShapeTest.Service;
using ShapeTest.Service.Impl;

Shape shape = new()
{
    Id = "SHAPE001",
    Rotation = new float[] { 1, 5, 3 },
    Position = new float[] { 1, 8, 3 },
    Scale = 12,
    AmountOfSides = 8,
    Height = 152,
    Width = 155
};

IShapeManager shapeManager =new ShapeManager();
shapeManager.Add(shape);
shapeManager.Add(shape);
shapeManager.PrintInformation("SHAPE001");
Console.ReadKey();


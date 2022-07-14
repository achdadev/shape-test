

using ShapeTest.Models;
using ShapeTest.Services;
using ShapeTest.Services.Impl;

Shape shape = new()
{
    Id = "SHAPE001",
    Rotation = new float[] { 1, 5, 3 },
    Position = new float[] { 1, 8, 3 },
    Scale = 12,
    AmountOfSides = 4,
    Height = 152,
    Width = 155
};

Shape shape2 = new()
{
    Id = "SHAPE002",
    Rotation = new float[] { 1, 2, 3 },
    Position = new float[] { 1, 5, 4 },
    Scale = 120,
    AmountOfSides = 4,
    Height = 200,
    Width = 200
};

IShapeManager shapeManager = new ShapeManager();
shapeManager.Add(shape);
shapeManager.Add(shape2);
shapeManager.PrintInformation("SHAPE001");
Console.WriteLine("** ALL SHAPES **");
shapeManager.PrintAllShapesInformation();
Console.ReadKey();


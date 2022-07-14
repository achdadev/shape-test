using ShapeTest.Models;

namespace ShapeTest.Services
{
    public interface IShapeManager
    {
        Shape Add(Shape shape);
        IEnumerable<Shape> GetAll();
        bool Delete(string id);
        void PrintInformation(string id);
        void PrintAllShapesInformation();

    }
}

using ShapeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest.Service
{
    public interface IShapeManager
    {
        Shape Add(Shape shape);
        IEnumerable<Shape> GetAll();
        bool Delete(string id);
        void PrintInformation(string id);

    }
}

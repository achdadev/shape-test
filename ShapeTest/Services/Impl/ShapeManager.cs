using ShapeTest.Models;

namespace ShapeTest.Services.Impl
{
    public class ShapeManager : IShapeManager
    {
        public static ISet<Shape> Data = new HashSet<Shape>();
        public Shape Add(Shape shape)
        {
            var isExist = Data.Where(s => s.Id == shape.Id).Any();
            if (isExist)
            {
                Console.WriteLine($"The shape with id {shape.Id} already exist");
                return null;
            }
            Data.Add(shape);
            return shape;
        }

        public bool Delete(string id)
        {
            var isExist = Data.Where(s => s.Id == id).Any();
            if (isExist)
            {
                var shapeToDelete = Data.Where(s => s.Id == id).First();
                Data.Remove(shapeToDelete);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get All shapes
        /// </summary>
        /// <param name="id"></param>
        public IEnumerable<Shape> GetAll()
        {
            return Data.AsEnumerable();
        }

        /// <summary>
        /// Edit shape Scale 
        /// </summary>
        /// <param name="id"></param>
        public void EditScale(string id, int scale)
        {
            var isExist = Data.Where(s => s.Id == id).Any();
            if (isExist)
            {
                var shape = Data.Where(s => s.Id == id).First();
                shape.Scale = scale;
            }
            else
            {
                Console.WriteLine($"Shape with Id {id} not found");
            }
        }

        /// <summary>
        /// Edit shape Rotation 
        /// </summary>
        /// <param name="id"></param>
        public void EditRotation(string id, float[] rotation)
        {
            var isExist = Data.Where(s => s.Id == id).Any();
            if (isExist)
            {
                var shape = Data.Where(s => s.Id == id).First();
                shape.Rotation = rotation;
            }
            else
            {
                Console.WriteLine($"Shape with Id {id} not found");
            }
        }

        /// <summary>
        /// Edit shape position 
        /// </summary>
        /// <param name="id"></param>
        public void EditPosition(string id, float[] position)
        {
            var isExist = Data.Where(s => s.Id == id).Any();
            if (isExist)
            {
                var shape = Data.Where(s => s.Id == id).First();
                shape.Position = position;
            }
            else
            {
                Console.WriteLine($"Shape with Id {id} not found");
            }
        }

        /// <summary>
        /// print shape informations
        /// </summary>
        /// <param name="id"></param>
        public void PrintInformation(string id)
        {
            var isExist = Data.Where(s => s.Id == id).Any();
            if (isExist)
            {
                var shape = Data.Where(s => s.Id == id).First();
                Console.WriteLine($"Shape Id:{shape.Id} information :\n" +
                    $" Width: {shape.Width}\n" +
                    $" Height:  {shape.Height} \n" +
                    $" AmountOfSides:  {shape.AmountOfSides} \n" +
                    $" Position:  {shape.Position[0]}, {shape.Position[1]}, {shape.Position[2]} \n" +
                    $" Scale:  {shape.Scale} \n" +
                    $" Rotation:  {shape.Rotation[0]}, {shape.Rotation[1]}, {shape.Rotation[2]} \n");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        public void PrintAllShapesInformation()
        {
            foreach (var shape in Data)
            {
                PrintInformation(shape.Id);
            }
        }
    }
}

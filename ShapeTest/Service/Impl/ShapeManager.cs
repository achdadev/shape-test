using ShapeTest.Models;

namespace ShapeTest.Service.Impl
{
    public class ShapeManager : IShapeManager
    {
        public static ISet<Shape> Data = new HashSet<Shape>();
        public Shape Add(Shape shape)
        {
            var isExist = Data.Where(s => s.Id == shape.Id).Any();
            if (isExist)
            {
                throw new Exception("The element already exist");
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
                Console.WriteLine($"Shape informarion: Id:{shape.Id} Width: {shape.Width} Height:  {shape.Height}  AmountOfSides:  {shape.AmountOfSides} Position:  {shape.Position[0]}, {shape.Position[1]}, {shape.Position[2]} Scale:  {shape.Scale} Rotation:  {shape.Rotation}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

    }
}

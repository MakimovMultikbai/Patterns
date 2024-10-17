namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaterialCreator woodCreator = new WoodCreator();
            woodCreator.DisplayMaterialInfo();

            MaterialCreator gasConcreteCreator = new GasConcreteCreator();
            gasConcreteCreator.DisplayMaterialInfo();

            MaterialCreator brickCreator = new BrickCreator();
            brickCreator.DisplayMaterialInfo();
        }
    }
}

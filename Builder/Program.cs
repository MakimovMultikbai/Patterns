namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICharacterBuilder warriorBuilder = new WarriorBuilder();
            CharacterDirector warriorDirector = new CharacterDirector(warriorBuilder);
            Character warrior = warriorDirector.BuildCharacter("Вадик");
            Console.WriteLine(warrior);

            Console.WriteLine();
            ICharacterBuilder mageBuilder = new MageBuilder();
            CharacterDirector mageDirector = new CharacterDirector(mageBuilder);
            Character mage = mageDirector.BuildCharacter("Алдияр");
            Console.WriteLine(mage);
        }
    }
}

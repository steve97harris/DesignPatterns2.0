namespace DesignPatterns._01_Creational._01_SimpleFactory.DoorFactory
{
    public static class DoorFactory
    {
        public static IDoor MakeWoodDoor(int height, int width)
        {
            WoodenDoor woodenDoor = new WoodenDoor(height,width);
            return woodenDoor;
        }

        public static IDoor MakeGlassDoor(int height, int width)
        {
            GlassDoor glassDoor = new GlassDoor(height,width);
            return glassDoor;
        }
    }
}
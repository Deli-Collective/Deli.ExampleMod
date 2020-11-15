using Deli;

namespace DeliExampleMod
{
    // Deli Mods are just mono behaviours that get added to a global game object when the game first starts.
    // Generally you want to put your setup code in Awake()
    public class DeliExampleMod : DeliMod
    {
        private void Awake()
        {
            // Hello, world!
            BaseMod.Log.LogInfo("Hello, world!");

            // Fetch and log the example resource
            var textResource = BaseMod.Resources.Get<string>("Resources/ExampleTextResource.txt").Unwrap();
            BaseMod.Log.LogInfo("Text resource contents: " + textResource);
            
            // TODO: Put the rest of your setup code here
        }
    }
}
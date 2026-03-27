using Oyster.Core.AbstractTypes.Scene;
using Oyster.Core.Interfaces.Things;

public class SceneScript : A_SceneScript
{
    // Constructor
    public SceneScript(IShowAndHide[] thingsToBeHiddenMidConversation, A_Looker[] lookers) : base(thingsToBeHiddenMidConversation, lookers) { }
}

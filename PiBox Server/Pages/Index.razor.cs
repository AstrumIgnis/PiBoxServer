using Microsoft.AspNetCore.Components;
using PiBox_Server.Sync;

namespace PiBox_Server.Pages
{
    public partial class Index : IComponent
    {
        [Inject]
        protected Messenger Messenger { get; set; } = default!;

        
        protected override async Task OnInitializedAsync()
        {
            Messenger.OnMessage += () => InvokeAsync(this.StateHasChanged);
        }

        private async Task ComeHere()
        {
            Messenger.AddMessage("Can you come here?");
        }
        private async Task RightUp()
        {
            Messenger.AddMessage("Be right up!");
        }
        private async Task InGame()
        {
            Messenger.AddMessage("In a game, will come up after");
        }
        private async Task Yes()
        {
            Messenger.AddMessage("Yes");
        }
        private async Task No()
        {
            Messenger.AddMessage("No");
        }
        private async Task Ok()
        {
            Messenger.AddMessage("Ok");
        }
        
    }
}

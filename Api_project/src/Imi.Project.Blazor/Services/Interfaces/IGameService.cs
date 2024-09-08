using Imi.Project.Blazor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Interfaces
{
    public interface IGameService
    {
        Task<GameItem> CreateGameItem();
        Task<string> CreateQuestion(GameItem gameItem);
        bool HandleAnswer(string check, GameItem gameItem);
        int GetTotalQuestion();
        int GetCorrectlyAnswers();
        void StartGame();
        bool CheckAnswer(string check, GameItem gameItem);
        Task Initialization();
    }
}

using Imi.Project.Blazor.Models;
using Imi.Project.Blazor.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public class GameService : IGameService
    {


        private int totalQuestions;
        private int correctlyAnswers;
        private readonly ICrudService<FishListItem, FishItem> _fishService;
        private List<FishListItem> fishes;

        public GameService( ICrudService<FishListItem, FishItem> fishService)
        {
            _fishService = fishService;
        }


        public async Task Initialization()
        {
            fishes = new List<FishListItem>();
            fishes = await _fishService.GetList();
        }

        private static Random GetRandom()
        {
            Random radom = new Random();
            return radom;
        }
        public async Task<GameItem> CreateGameItem()
        {
            var gameItem = new GameItem();
            int radomFish = GetRandom().Next(0, fishes.Count());

            var fish = fishes[radomFish];
            List<string> allImages = fishes.Select(x => x.UrlImage).ToList();
            int radomImage = GetRandom().Next(1, allImages.Count() - 4);
            int radomImageGame = GetRandom().Next(0, 3);
            var imagesGame = allImages.Skip(radomImage).Take(4).ToList();
            if (!imagesGame.Contains(fish.UrlImage))
            {
                imagesGame.Remove(imagesGame[radomImageGame]);
                imagesGame.Insert(radomImageGame, fish.UrlImage);
            }
            gameItem.Id = fish.Id;
            gameItem.FishName = fish.Name;
            gameItem.Images = imagesGame;
            gameItem.CorrectlyImage = fish.UrlImage;
            return gameItem;
        }

        public void StartGame()
        {
            totalQuestions = 1;
            correctlyAnswers = 0;

        }

        public Task<string> CreateQuestion(GameItem gameItem)
        {

            return Task.FromResult($" What is de correct foto van {gameItem.FishName}");
        }

        public bool HandleAnswer(string check, GameItem gameItem)
        {
            if (totalQuestions < 10)
            {
                if (CheckAnswer(check, gameItem))
                {
                    correctlyAnswers++;
                }
                totalQuestions++;

                return true;
            }
            else
            {
                if (CheckAnswer(check, gameItem))
                {
                    correctlyAnswers++;
                }
                return false;
            }
        }

        public bool CheckAnswer(string check, GameItem gameItem)
        {
            return check.ToLower().Equals(gameItem.CorrectlyImage.ToLower());
        }
        public int GetCorrectlyAnswers()
        {
            return correctlyAnswers;
        }
        public int GetTotalQuestion()
        {
            return totalQuestions;
        }

    }
}

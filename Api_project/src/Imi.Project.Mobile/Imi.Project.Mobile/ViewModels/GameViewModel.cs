using FreshMvvm;
using Imi.Project.Mobile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.ViewModels
{
    public class GameViewModel: FreshBasePageModel
    {
        protected readonly IGameService _gameService;
        private string titel;

        public string Titel
        {
            get { return titel; }
            set { titel = value; RaisePropertyChanged(); }
        }

        public GameViewModel(IGameService gameService)
        {
            Titel = "Deze Pagina wordt later behandelen";
            _gameService = gameService;
        }
    }
}

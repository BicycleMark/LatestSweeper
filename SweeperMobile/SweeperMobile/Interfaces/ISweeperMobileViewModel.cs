using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SweeperMobile.Interfaces
{
    public interface ISweeperGame
    {   
        IEnumerable<IGamePiece> Board { get; }
        int Columns { get; }
        int CurrCol { get; }
        int CurrRow { get; }
        string DebugRow { get; set; }
        /*
        RelayCommand AboutCommand { get; set; }
        RelayCommand FlagCommand { get; set; }
        bool GameBoardEnabled { get; }
        RelayCommand GameClearMessages { get; set; }
        RelayCommand GameExitCommand { get; set; }
        bool GameInProgress { get; }
        RelayCommand GameLogShownCommand { get; set; }
        RelayCommand GameOptionsCommand { get; set; }
        GameConstants.GameStates GameState { get; set; }
        RelayCommand GameThemeCommand { get; set; }
        RelayCommand LeaveSmileyCommand { get; set; }
        RelayCommand NewGameCommand { get; set; }
        RelayCommand OpenThemesCommand { get; set; }
        RelayCommand PlayCommand { get; set; }
        RelayCommand PressSmileyCommand { get; set; }
        */
        GameConstants.GameTypes GameType { get; }
        ObservableCollection<string> GameTypes { get; set; }
        int Height { get; set; }
        bool IsAdvanced { get; }
        bool IsBeginner { get; }
        bool IsCustom { get; }
        bool IsExpanded { get; set; }
        bool IsIntermediate { get; }
        bool IsLogWindowShown { get; set; }     
        int MaxHeight { get; set; }
        int MaxWidth { get; set; }
        int Mines { get; }
        int MinHeight { get; set; }
        int MinWidth { get; set; }   
        int Rows { get; }
        bool SoundsOn { get; set; }
        string Theme { get; set; }
        ObservableCollection<string> Themes { get; set; }
        int Time { get; }
        string Title { get; set; }
        int Width { get; set; }
    }
}
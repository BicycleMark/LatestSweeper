using SweeperMobile;

namespace SweeperMobile.Interfaces
{
    public interface IGamePiece
    {
        GameConstants.PieceValues ActualValue { get; set; }
        int C { get; set; }
        bool IsFlagged { get; }
        bool IsPlayed { get; }
        bool IsPressed { get; }
        int LinearIndex { get; set; }
        int R { get; set; }
        GameConstants.PieceValues Value { get; set; }

        void OnPropertyChanged(string prop);
    }
}
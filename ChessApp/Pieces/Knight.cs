namespace ChessApp.Pieces
{
    public class Knight : Pieces
    {
        private bool _pinned;

        public Knight(int pieceID, int pieceValue, bool colour, int xposition, int yposition, bool pinned) : base(pieceID, pieceValue, colour, xposition, yposition)
        {
            PieceID = pieceID;
            PieceValue = pieceValue;
            Colour = colour;
            Xposition = xposition;
            Yposition = yposition;
            Pinned = pinned;
        }

        public bool Pinned
        {
            get
            {
                return _pinned;
            }
            set
            {
                _pinned = value;
            }
        }
    }
}

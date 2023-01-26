namespace ChessApp.Pieces
{
    public class Rook : Pieces
    {
        private bool _pinned, _hasmoved;

        public Rook(int pieceID, int pieceValue, bool colour, int xposition, int yposition, bool pinned, bool hasmoved) : base(pieceID, pieceValue, colour, xposition, yposition)
        {
            PieceID = pieceID;
            PieceValue = pieceValue;
            Colour = colour;
            Xposition = xposition;
            Yposition = yposition;
            Pinned = pinned;
            HasMoved = hasmoved;
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

        public bool HasMoved
        {
            get
            {
                return _hasmoved;
            }
            set
            {
                _hasmoved = value;
            }
        }
    }
}

namespace ChessApp.Pieces
{
    public class King : Pieces
    {
        private bool _mated, _check, _cancastle;

        public King(int pieceID, int pieceValue, bool colour, int xposition, int yposition, bool mated, bool check, bool cancastle) : base(pieceID, pieceValue, colour, xposition, yposition)
        {
            PieceID = pieceID;
            PieceValue = pieceValue;
            Colour = colour;
            Xposition = xposition;
            Yposition = yposition;
            Mated = mated;
            Check = check;
            CanCastle = cancastle;
        }

        public bool Mated
        {
            get
            {
                return _mated;
            }
            set
            {
                _mated = value;
            }
        }

        public bool Check
        {
            get
            {
                return _check;
            }
            set
            {
                _check = value;
            }
        }

        public bool CanCastle
        {
            get
            {
                return _cancastle;
            }
            set
            {
                _cancastle = value;
            }
        }
    }
}

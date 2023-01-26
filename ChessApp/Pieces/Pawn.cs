namespace ChessApp.Pieces
{
    public class Pawn : Pieces
    {
        private bool _pinned, _hasmoved, _canenpassant;
        private int _promoteid;

        public Pawn(int pieceID, int pieceValue, bool colour, int xposition, int yposition, bool pinned, bool hasmoved, int promoteid, bool canenpassant) : base(pieceID, pieceValue, colour, xposition, yposition)
        {
            PieceID = pieceID;
            PieceValue = pieceValue;
            Colour = colour;
            Xposition = xposition;
            Yposition = yposition;
            Pinned = pinned;
            HasMoved = hasmoved;
            Canenpassant = canenpassant;
            PromoteID = promoteid;
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

        public int PromoteID
        {
            get
            {
                return _promoteid;
            }
            set
            {
                _promoteid = value;
            }
        }

        public bool Canenpassant
        {
            get
            {
                return _canenpassant;
            }
            set
            {
                _canenpassant = value;
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

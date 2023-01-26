using System.Drawing;

namespace ChessApp.Pieces
{
    public abstract class Pieces
    {
        private int _pieceID, _piecevalue, _xposition, _yposition;
        private bool _colour;

        protected Pieces(int pieceID , int pieceValue, bool colour, int xPosition, int yPosition)
        {
            PieceID = pieceID ;
            PieceValue = pieceValue ;
            Colour = colour;
            Xposition = xPosition ;
            Yposition = yPosition ;
        }

        public int PieceID
        {
            get
            {
                return _pieceID;
            }
            set
            {
                _pieceID = value;
            }
        }

        public int PieceValue
        {
            get
            {
                return _piecevalue;
            }
            set
            {
                _piecevalue = value;
            }
        }

        public int Xposition
        {
            get
            {
                return _xposition;
            }
            set
            {
                _xposition = value;
            }
        }

        public int Yposition
        {
            get
            {
                return _yposition;
            }
            set
            {
                _yposition = value;
            }
        }

        public bool Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }
        }
    }
}

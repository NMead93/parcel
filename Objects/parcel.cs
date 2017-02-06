namespace Parcel.Objects
{
    public class ParcelVariables
    {
        private int _length;
        private int _width;
        private int _height;
        private int _weight;
        private int _volume;

      

        public int GetLength()
        {
            return _length;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetLength(int length)
        {
            _length = length;
        }

        public void SetWidth(int width)
        {
            _width = width;
        }

        public void SetHeight(int height)
        {
            _height = height;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public void SetVolume()
        {
            _volume = _length * _width * _height;
        }

        public int CostToShip()
        {
            if (_weight <= 2)
            {
                return 10;
            }
            else if (2 < _weight && _weight < 5)
            {
                return 20;
            }
            else
            {
                return 30;
            }
        }
    }
}
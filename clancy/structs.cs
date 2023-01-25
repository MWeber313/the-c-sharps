using System;

namespace structs
{
    internal class Program 
    {
        static void main(string args[]) 
        {
            Biscuit chocChip = new Biscuit("Chocolate Chip", true, 3);

        }
    public struct Biscuit {
        private string _name;
        private bool _isDelish;
        private byte _servingSize;

        public Biscuit(string name, bool isDelish, byte servingSize) {
            _name = name;
            _isDelish = isDelish;
            _servingSize = servingSize;
        }
    }
    }
    
}
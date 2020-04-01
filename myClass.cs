namespace GitExercise
{
    class myClass
    {
        private string _navn;
        private string _addresse;
        private int _postNr;

        public myClass(string Navn, string Addresse, int PostNr)
        {
            _navn = Navn;
            _addresse = Addresse;
            _postNr = PostNr;
        }

        public int PostNr { get => _postNr; set => _postNr = value; }
        public string Addresse { get => _addresse; set => _addresse = value; }
        public string Navn { get => _navn; set => _navn = value; }

        public override string ToString()
        {
            return $"{Navn}'s addresse er {Addresse} med postNr {PostNr}";
        }

        
    }
}
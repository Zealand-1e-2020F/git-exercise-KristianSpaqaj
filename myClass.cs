namespace GitExercise
{
    class myClass
    {
        private string _navn;
        private string _addresse;
        private int _postNr;


        public int PostNr { get => _postNr; set => _postNr = value; }
        public string Addresse { get => _addresse; set => _addresse = value; }
        public string Navn { get => _navn; set => _navn = value; }
    }
}
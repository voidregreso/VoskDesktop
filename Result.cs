namespace RecogUI
{
    public class Result
    {
        public class Words
        {
            public float conf { get; set; } // confidence
            public float end { get; set; }
            public float start { get; set; }
            public string word { get; set; } = "";
        }

        public string partial { get; set; } = "";
        public Words[] result { get; set; }
        public string text { get; set; } = "";
    }
}
